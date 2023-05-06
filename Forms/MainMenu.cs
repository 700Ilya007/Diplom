using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InvAc.Forms
{
    public partial class MainMenu : Form
    {
        private readonly checkUser _user;
        public MainMenu(checkUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void IsAdmin()
        {

            ButtonAdmin.Enabled = _user.IsAdmin;
            ButtonAdmin.Visible = _user.IsAdmin;
        }


        Point lastPoint;
        private void MainMenuText_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainMenuText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
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

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator administrator = new Administrator(_user);
            administrator.ShowDialog();

        }
        private void ButtonProvider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Provider provider = new Provider(_user);
            provider.ShowDialog();
        }
        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventory = new Inventory(_user);
            inventory.ShowDialog();

        }



        private void ButtonDefectiveInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            DefectiveInventory defectiveInventory = new DefectiveInventory(_user);
            defectiveInventory.ShowDialog();
        }



     

        private void PictureExitAccount_MouseMove(object sender, MouseEventArgs e)
        {
            PictureExitAccount.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureExitAccount_MouseLeave(object sender, EventArgs e)
        {
            PictureExitAccount.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            TextBoxStatus.Text = $"{_user.Login}";
            IsAdmin();
        }




        private void PictureExit_MouseLeave(object sender, EventArgs e)
        {
            PictureExit.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureExit_MouseMove(object sender, MouseEventArgs e)
        {
            PictureExit.BackColor = Color.FromArgb(12, 82, 116);
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

        private void PictureExitAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase purchase = new Purchase(_user);
            purchase.ShowDialog();
        }
    }
}
