using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace InvAc.Forms
{

   enum RowState
    {
        Existed,
        New,
        Modfield,
        ModfieldNew,
        Deleted
    }
    public partial class Inventory : Form
    {
        public readonly checkUser _user;
        DataBase dataBase = new DataBase();

        int selectedRow;
        public Inventory(checkUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void CreateColumns()
        {
            DGVInventory.Columns.Add("id", "id");
            DGVInventory.Columns.Add("NameInventory", "Название инвентаря");
            DGVInventory.Columns.Add("NumberOfInventory", "Количество инвентаря");
            DGVInventory.Columns.Add("Price", "Цена (в руб.)");
            DGVInventory.Columns.Add("IsNew", string.Empty);

            DGVInventory.Columns[0].Visible = false;
            DGVInventory.Columns[4].Visible = false;


            DGVInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearTextBoxs()

        {
            TextBoxIDInventory.Text = "";
            TextBoxNameInventory.Text = "";
            TextBoxNumberOfInventory.Text = "";
            TextBoxPrice.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), RowState.ModfieldNew);
        }

        private void RefresDataGrid(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string queryString = $"select * from Inventory";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
    
        private void Inventory_Load(object sender, EventArgs e)
        {

            CreateColumns();
            RefresDataGrid(DGVInventory);
        }

        private void LeftBack_Click(object sender, EventArgs e)
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

        private void DGVInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVInventory.Rows[selectedRow];
                TextBoxIDInventory.Text = row.Cells[0].Value.ToString();
                TextBoxNameInventory.Text = row.Cells[1].Value.ToString();
                TextBoxNumberOfInventory.Text = row.Cells[2].Value.ToString();
                TextBoxPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        private void PictureRefreshTable_Click(object sender, EventArgs e)
        {
            RefresDataGrid(DGVInventory);
            ClearTextBoxs();
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            ADDInventory addinventory = new ADDInventory(_user);
            addinventory.ShowDialog();
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searcString = $"select * from Inventory where concat (ID_Inventory, NameInventory, NumberOfInventory, Price) like '%" + TextBoxSearch.Text + "%'";

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
            int index = DGVInventory.CurrentCell.RowIndex;

            DGVInventory.Rows[index].Visible = false;

            if (DGVInventory.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                DGVInventory.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            DGVInventory.Rows[index].Cells[4].Value = RowState.Deleted;
        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

            Search(DGVInventory);
        }


        private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < DGVInventory.Rows.Count; index++)
            {
                var rowState = (RowState)DGVInventory.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(DGVInventory.Rows[index].Cells[0].Value);

                    var deleteQuery = $"delete from Inventory where ID_Inventory = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();


                }

                if (rowState == RowState.Modfield)
                {
                    var id = DGVInventory.Rows[index].Cells[0].Value.ToString();
                    var name = DGVInventory.Rows[index].Cells[1].Value.ToString();
                    var number = DGVInventory.Rows[index].Cells[2].Value.ToString();
                    var price = DGVInventory.Rows[index].Cells[3].Value.ToString();

                    var changerQouery = $"update Inventory set NameInventory = '{name}', NumberOfInventory = '{number}', Price = '{price}' where ID_Inventory = '{id}'";

                    var command = new SqlCommand(changerQouery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
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
            var selectedRowIndex = DGVInventory.CurrentCell.RowIndex;

            var id = TextBoxIDInventory.Text;
            var name = TextBoxNameInventory.Text;
            int number;
            decimal price;
          

            if (DGVInventory.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {


                if (int.TryParse(TextBoxNumberOfInventory.Text, out number))
                    
 
                if (decimal.TryParse(TextBoxPrice.Text, out price))
                {
                    DGVInventory.Rows[selectedRowIndex].SetValues(id, name, number, price);
                    DGVInventory.Rows[selectedRowIndex].Cells[4].Value = RowState.Modfield;
                }

                else
                    {
                        MessageBox.Show("Цена должна иметь числовой формат!");
                    }

            }
        }
        private void ButtonChange_Click(object sender, EventArgs e)
        {

            if (TextBoxNameInventory.Text != string.Empty && TextBoxNumberOfInventory.Text != string.Empty && TextBoxPrice.Text != string.Empty)
            {
                Change();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void TextBoxNumberOfInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }


      

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {

            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //Добавление строк и ячеек
                int r = 0;
                for (int c = 1; c <= ColumnCount - 2; c++)
                {
                    for (r = 1; r <= RowCount - 2; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //Ориентация листа
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //Формат таблицы
                oRange.Text = oTemp;
                object oMissing = Missing.Value;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;



                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                  Type.Missing, Type.Missing, ref ApplyBorders,
                                  Type.Missing, Type.Missing, Type.Missing,
                                  Type.Missing, Type.Missing, Type.Missing,
                                  Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //Стиль заголовка таблицы
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 2;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 1; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //Стили таблицы
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                oDoc.Application.Selection.Tables[1].Borders.Enable = 1;

                //Сохранение файла

                oDoc.SaveAs(filename, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);
            }
        }


        private void вWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "Word.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(DGVInventory, sfd.FileName);
            }
        }

        private void вExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 1; i <= DGVInventory.RowCount - 1; i++)
            {
                for (j = 1; j <= DGVInventory.ColumnCount - 2; j++)
                {
                    wsh.Cells[1, j + 0] = DGVInventory.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 1, j + 0] = DGVInventory[j, i].Value.ToString();

                }
            }
            exApp.Visible = true;
        }
    }

}


