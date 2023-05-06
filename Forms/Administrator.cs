using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvAc.Forms
{
    public partial class Administrator : Form
    {

        DataBase dataBase = new DataBase();

        private readonly checkUser _user;
        public Administrator(checkUser user)
        {
            _user = user;
            InitializeComponent();

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vedenie_UchetaDataSet1.register". При необходимости она может быть перемещена или удалена.
            this.registerTableAdapter.Fill(this.vedenie_UchetaDataSet1.register);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                registerBindingSource.EndEdit();
                registerTableAdapter.Update(vedenie_UchetaDataSet1);
                MessageBox.Show("Запись сохранена!", "Предупреждение!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Заполните все поля");
            }
        }

        private void ButtonDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)


            {

                registerBindingSource.RemoveCurrent();
                registerBindingSource.EndEdit();
                registerTableAdapter.Update(vedenie_UchetaDataSet1);

            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }
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

        private void ButtonADDAccount_Click(object sender, EventArgs e)
        {
            try
            {
                registerBindingSource.AddNew();
                registerTableAdapter.Update(vedenie_UchetaDataSet1);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Заполните все поля");
            }
        }
    }
}
