using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using InvAc.Forms;

namespace InvAc
{
    public partial class LoginForm : Form
        
    {
        DataBase dataBase = new DataBase();

        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            

            this.TextBoxPassword.AutoSize = false;
            this.TextBoxPassword.Size = new Size(this.TextBoxPassword.Width, 50);
        }


        
        private void ButtonCome_Click(object sender, EventArgs e)
        {
           
        
            if (TextBoxLogin.Text == "" || TextBoxPassword.Text == "")
                MessageBox.Show("Поле логин/пароль пустое");
            else
            {
                var loginUser = TextBoxLogin.Text.Trim();
                var passUser = TextBoxPassword.Text.Trim();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user = '{passUser}'";

                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);



                if (table.Rows.Count == 1)
                {

                    var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Forms.MainMenu frm1 = new Forms.MainMenu(user);
                    frm1.ShowDialog();



                }
                else
                    MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            TextBoxLogin.MaxLength = 12;
            TextBoxPassword.MaxLength = 10;
        }

        private void PictureOpenEye_Click(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = true;
            PictureCloseEye.Visible = true;
            PictureOpenEye.Visible = false;
        }

        private void PictureCloseEye_Click(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = false;
            PictureCloseEye.Visible = false;
            PictureOpenEye.Visible = true;
        }

        private void PictureClear_Click(object sender, EventArgs e)
        {
                TextBoxLogin.Text = "";
                TextBoxPassword.Text = "";
           
        }

        private void TextBoxLogin_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(TextBoxLogin, "Максимум 12 символов");
        }

        private void TextBoxPassword_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(TextBoxPassword, "Максимум 10 символов");
        }

        
        private void PictureNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm registrForm = new RegistrForm();
            registrForm.ShowDialog();
        }

        private void PictureNewUser_MouseLeave(object sender, EventArgs e)
        {
            PictureNewUser.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureNewUser_MouseMove(object sender, MouseEventArgs e)
        {
            PictureNewUser.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureNewUser_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureNewUser, "Создание нового аккаунта");
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
            PictureExit.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureExit_MouseMove(object sender, MouseEventArgs e)
        {
            PictureExit.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureClear_MouseLeave(object sender, EventArgs e)
        {
            PictureClear.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureClear_MouseMove(object sender, MouseEventArgs e)
        {
            PictureClear.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureOpenEye_MouseLeave(object sender, EventArgs e)
        {
            PictureOpenEye.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureOpenEye_MouseMove(object sender, MouseEventArgs e)
        {
            PictureOpenEye.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureCloseEye_MouseLeave(object sender, EventArgs e)
        {
            PictureCloseEye.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void PictureCloseEye_MouseMove(object sender, MouseEventArgs e)
        {
            PictureCloseEye.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void PictureClear_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureClear, "Очистить поля логин и пароль");
        }

        private void PictureCloseEye_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureCloseEye, "Показать пароль");
        }

        private void PictureOpenEye_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureOpenEye, "Скрыть пароль");
        }

        private void LeftBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
        }

        private void LeftBack_MouseLeave(object sender, EventArgs e)
        {
            LeftBack.BackColor = Color.FromArgb(46, 109, 156);
        }

        private void LeftBack_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBack.BackColor = Color.FromArgb(12, 82, 116);
        }

        private void LeftBack_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(LeftBack, "Вернуться назад");
        }

        private void PictureExit_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureExit, "Выйти из приложения");
        }

        Point lastPoint;

        private void AutorizationText_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AutorizationText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}

