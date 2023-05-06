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

namespace InvAc
{
    public partial class RegistrForm : Form
    {
        DataBase dataBase = new DataBase();
        public RegistrForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

       

        Point lastPoint;

        private void Registrext_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Registrext_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

       
        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            if (checkuser())
            {
                return;
            }
            if (TextBoxLogin.Text == "" || TextBoxPassword.Text == "")
                MessageBox.Show("Поле логин/пароль пустое");
            else
            {


                var login = TextBoxLogin.Text;
                var password = TextBoxPassword.Text;

                string querystring = $"Insert into  register(login_user, password_user, is_admin) values ('{login}', '{password}', 0)";

                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                }

                else
                {

                    MessageBox.Show("Аккаунт не создан!");
                }
                dataBase.closeConnection();
            }
        }
            private Boolean checkuser()
            {
                var loginuser = TextBoxLogin.Text;
                var passworduser = TextBoxPassword.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginuser}' and  password_user = '{passworduser}'";

                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь уже сущестует!");
                    return true;
                }

                else
                {
                    return false;
                }

            }

    

        


        private void PictureCloseEye_Click(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = false;
            PictureCloseEye.Visible = false;
            PictureOpenEye.Visible = true;
        }
        private void PictureOpenEye_Click(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = true;
            PictureCloseEye.Visible = true;
            PictureOpenEye.Visible = false;
        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {
           
            TextBoxLogin.MaxLength = 12;
            TextBoxPassword.MaxLength = 10;
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

        private void PictureClear_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureClear, "Очистить поля логин и пароль" );
        }

        private void PictureOpenEye_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureOpenEye, "Скрыть пароль");
        }

        private void PictureCloseEye_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(PictureCloseEye, "Показать пароль");
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
    }
    } 

