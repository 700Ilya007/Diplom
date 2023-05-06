using InvAc.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvAc
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void ButtonAutorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();

            loginform.ShowDialog();
           

        }

        private void ButtonRegistr_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm registrform = new RegistrForm();
            registrform.ShowDialog();
            


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

        private void PictureExit_MouseLeave(object sender, EventArgs e)
        {
            PictureExit.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureExit_MouseMove(object sender, MouseEventArgs e)
        {
            PictureExit.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureExit_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureExit, "Выйти из приложения");
        }

       
    }
}
