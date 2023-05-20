using InvAc.Vedenie_UchetaDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvAc.Forms
{
    public partial class Provider : Form
    {

        DataBase dataBase = new DataBase();
        public readonly checkUser _user;
        public Provider(checkUser user)
        {
            _user = user;
            InitializeComponent();
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

        Point lastPoint;
        private void LabelProvider_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LabelProvider_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
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

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vedenie_UchetaDataSet1);

        }

        private void Provider_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vedenie_UchetaDataSet1.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.vedenie_UchetaDataSet1.Provider);

        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            try
            {
                providerBindingSource.AddNew();
                providerTableAdapter.Update(vedenie_UchetaDataSet1);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Заполните все поля");
            }


        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)


            {

                providerBindingSource.RemoveCurrent();
                providerBindingSource.EndEdit();
                providerTableAdapter.Update(vedenie_UchetaDataSet1);

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
                providerBindingSource.EndEdit();
                providerTableAdapter.Update(vedenie_UchetaDataSet1);
            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }
        }
    }
}
