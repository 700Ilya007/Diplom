using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace InvAc.Forms
{
    enum RowState1
    {
        Existed,
        New,
        Modfield,
        ModfieldNew,
        Deleted
    }
    public partial class DefectiveInventory : Form
    {
        public readonly checkUser _user;
        DataBase dataBase = new DataBase();

        int selectedRow;
        public DefectiveInventory(checkUser user)
        {
            _user = user;
            InitializeComponent();

        }


        private void CreateColumns()
        {
            DGVDefectiveInventory.Columns.Add("id", "id");
            DGVDefectiveInventory.Columns.Add("NameDefectiveInventory", "Название бракованного инвентаря");
            DGVDefectiveInventory.Columns.Add("NumberOfDefectiveInventory", "Количество бракованного инвентаря");
            DGVDefectiveInventory.Columns.Add("ReasonOfDefective", "Причина бракования");
            DGVDefectiveInventory.Columns.Add("IsNew", string.Empty);
            DGVDefectiveInventory.Columns[0].Visible = false;
            DGVDefectiveInventory.Columns[4].Visible = false;

            DGVDefectiveInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearTextBoxs()

        {
            TextBoxID_DefectiveInventory.Text = "";
            TextBoxNameDefectiveInventory.Text = "";
            TextBoxNumberOfDefectiveInventory.Text = "";
            TextBoxReasonOfDefective.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), RowState.ModfieldNew);
        }

        private void RefresDataGrid(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string queryString = $"select * from DefectiveInventory";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }






        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }
        }

        private void LinkLabelDefectiveInventory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            MainMenu mainmenu = new MainMenu(_user);
            mainmenu.ShowDialog();


        }


        private void PictureExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }
        }

        private void LeftBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu(_user);
            mainmenu.ShowDialog();
        }

        private void LeftBack_MouseLeave(object sender, EventArgs e)
        {
            LeftBack.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void LeftBack_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBack.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureExit_MouseLeave(object sender, EventArgs e)
        {
            PictureExit.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureExit_MouseMove(object sender, MouseEventArgs e)
        {
            PictureExit.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureExit_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureExit, "Выйти из приложения");
        }

        private void LeftBack_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(LeftBack, "Вернуться назад");
        }

        private void defectiveInventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.defectiveInventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vedenie_UchetaDataSet1);

        }

        private void DefectiveInventory_Load(object sender, EventArgs e)
        {

            CreateColumns();
            RefresDataGrid(DGVDefectiveInventory);
        }

        private void DGVDefectiveInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVDefectiveInventory.Rows[selectedRow];
                TextBoxID_DefectiveInventory.Text = row.Cells[0].Value.ToString();
                TextBoxNameDefectiveInventory.Text = row.Cells[1].Value.ToString();
                TextBoxNumberOfDefectiveInventory.Text = row.Cells[2].Value.ToString();
                TextBoxReasonOfDefective.Text = row.Cells[3].Value.ToString();
               
            }
            
        }

        private void PictureRefreshTable_Click(object sender, EventArgs e)
        {
            RefresDataGrid(DGVDefectiveInventory);
            ClearTextBoxs();
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            Forms.ADDDefectiveInventory addDI = new ADDDefectiveInventory(_user);
            addDI.ShowDialog();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searcString = $"select * from DefectiveInventory where concat (ID_DefectiveInventory, NameDefectiveInventory, NumberOfDefectiveInventory, ReasonOfDefective) like '%" + TextBoxSearch.Text + "%'";

            SqlCommand com = new SqlCommand(searcString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void deleteRow()
        {
            int index = DGVDefectiveInventory.CurrentCell.RowIndex;

            DGVDefectiveInventory.Rows[index].Visible = false;

            if (DGVDefectiveInventory.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                DGVDefectiveInventory.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            DGVDefectiveInventory.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(DGVDefectiveInventory);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {     
                deleteRow();
            ClearTextBoxs();
            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }

        }


        private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < DGVDefectiveInventory.Rows.Count; index++)
            {
                var rowState = (RowState)DGVDefectiveInventory.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(DGVDefectiveInventory.Rows[index].Cells[0].Value);

                    var deleteQuery = $"delete from DefectiveInventory where ID_DefectiveInventory = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();


                }

                if (rowState == RowState.Modfield)
                {
                    var id = DGVDefectiveInventory.Rows[index].Cells[0].Value.ToString();
                    var name = DGVDefectiveInventory.Rows[index].Cells[1].Value.ToString();
                    var number = DGVDefectiveInventory.Rows[index].Cells[2].Value.ToString();
                    var reason = DGVDefectiveInventory.Rows[index].Cells[3].Value.ToString();

                    var changerQouery = $"update DefectiveInventory set NameDefectiveInventory = '{name}', NumberOfDefectiveInventory = '{number}', ReasonOfDefective = '{reason}' where ID_DefectiveInventory = '{id}'";

                    var command = new SqlCommand(changerQouery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)


            {
                Update();
            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }
        }

        private void Change()
        {
            var selectedRowIndex = DGVDefectiveInventory.CurrentCell.RowIndex;

            var id = TextBoxID_DefectiveInventory.Text;
            var name = TextBoxNameDefectiveInventory.Text;
            int number;
            var reason = TextBoxReasonOfDefective.Text;


            if (DGVDefectiveInventory.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {


                if (int.TryParse(TextBoxNumberOfDefectiveInventory.Text, out number))

                    {
                        DGVDefectiveInventory.Rows[selectedRowIndex].SetValues(id, name, number, reason);
                        DGVDefectiveInventory.Rows[selectedRowIndex].Cells[4].Value = RowState.Modfield;
                    }

            }
         
    }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (TextBoxNameDefectiveInventory.Text != string.Empty && TextBoxNumberOfDefectiveInventory.Text != string.Empty && TextBoxReasonOfDefective.Text != string.Empty)
            {
                Change();
            ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void TextBoxNumberOfDefectiveInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 1; i <= DGVDefectiveInventory.RowCount - 1; i++)
            {
                for (j = 1; j <= DGVDefectiveInventory.ColumnCount - 2; j++)
                {
                    wsh.Cells[1, j + 0] = DGVDefectiveInventory.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 1, j + 0] = DGVDefectiveInventory[j, i].Value.ToString();

                }
            }
            exApp.Visible = true;
        }
       

        private void PictureRefreshTable_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureRefreshTable, "Обновить таблицу");
        }

        private void PictureRefreshTable_MouseLeave(object sender, EventArgs e)
        {
            PictureRefreshTable.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureRefreshTable_MouseMove(object sender, MouseEventArgs e)
        {
            PictureRefreshTable.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void ToolStripMenuItemExportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= DGVDefectiveInventory.RowCount - 1; i++)
            {
                for (j = 1; j <= DGVDefectiveInventory.ColumnCount - 2; j++)
                {
                    wsh.Cells[1, j + 0] = DGVDefectiveInventory.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 1, j + 0] = DGVDefectiveInventory[j, i].Value.ToString();

                }
            }
            exApp.Visible = true;
        }

        private void ToolStripMenuItemImportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Office |*.xls; *xlsx";
            openFileDialog1.ShowDialog();
            strFileName = openFileDialog1.FileName;

            if (strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                xlWorksheet = xlWorkbook.Worksheets["Лист1"];
                xlRange = xlWorksheet.UsedRange;

                int i = 0;

                for (xlRow = 1; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    DGVDefectiveInventory.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text);
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }
        }
    }
}
