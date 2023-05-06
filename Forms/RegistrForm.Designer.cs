namespace InvAc
{
    partial class RegistrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrForm));
            this.RegistrPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureClear = new System.Windows.Forms.PictureBox();
            this.PictureCloseEye = new System.Windows.Forms.PictureBox();
            this.PicturePassword = new System.Windows.Forms.PictureBox();
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.PictureOpenEye = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftBack = new System.Windows.Forms.PictureBox();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.PictureKey = new System.Windows.Forms.PictureBox();
            this.Registrext = new System.Windows.Forms.Label();
            this.RegistrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCloseEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOpenEye)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureKey)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrPanel
            // 
            this.RegistrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.RegistrPanel.Controls.Add(this.label2);
            this.RegistrPanel.Controls.Add(this.label1);
            this.RegistrPanel.Controls.Add(this.PictureClear);
            this.RegistrPanel.Controls.Add(this.PictureCloseEye);
            this.RegistrPanel.Controls.Add(this.PicturePassword);
            this.RegistrPanel.Controls.Add(this.PictureUser);
            this.RegistrPanel.Controls.Add(this.ButtonRegistration);
            this.RegistrPanel.Controls.Add(this.TextBoxPassword);
            this.RegistrPanel.Controls.Add(this.TextBoxLogin);
            this.RegistrPanel.Controls.Add(this.PictureOpenEye);
            this.RegistrPanel.Location = new System.Drawing.Point(0, 0);
            this.RegistrPanel.Name = "RegistrPanel";
            this.RegistrPanel.Size = new System.Drawing.Size(380, 450);
            this.RegistrPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Логин";
            // 
            // PictureClear
            // 
            this.PictureClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureClear.Image = global::InvAc.Properties.Resources.Clean;
            this.PictureClear.Location = new System.Drawing.Point(335, 119);
            this.PictureClear.Name = "PictureClear";
            this.PictureClear.Size = new System.Drawing.Size(35, 35);
            this.PictureClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureClear.TabIndex = 18;
            this.PictureClear.TabStop = false;
            this.PictureClear.Click += new System.EventHandler(this.PictureClear_Click);
            this.PictureClear.MouseLeave += new System.EventHandler(this.PictureClear_MouseLeave);
            this.PictureClear.MouseHover += new System.EventHandler(this.PictureClear_MouseHover);
            this.PictureClear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureClear_MouseMove);
            // 
            // PictureCloseEye
            // 
            this.PictureCloseEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureCloseEye.Image = global::InvAc.Properties.Resources.OpenEye;
            this.PictureCloseEye.Location = new System.Drawing.Point(335, 238);
            this.PictureCloseEye.Name = "PictureCloseEye";
            this.PictureCloseEye.Size = new System.Drawing.Size(35, 35);
            this.PictureCloseEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureCloseEye.TabIndex = 14;
            this.PictureCloseEye.TabStop = false;
            this.PictureCloseEye.Click += new System.EventHandler(this.PictureCloseEye_Click);
            this.PictureCloseEye.MouseLeave += new System.EventHandler(this.PictureCloseEye_MouseLeave);
            this.PictureCloseEye.MouseHover += new System.EventHandler(this.PictureCloseEye_MouseHover);
            this.PictureCloseEye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureCloseEye_MouseMove);
            // 
            // PicturePassword
            // 
            this.PicturePassword.Image = global::InvAc.Properties.Resources.Password;
            this.PicturePassword.Location = new System.Drawing.Point(0, 280);
            this.PicturePassword.Name = "PicturePassword";
            this.PicturePassword.Size = new System.Drawing.Size(64, 55);
            this.PicturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePassword.TabIndex = 12;
            this.PicturePassword.TabStop = false;
            // 
            // PictureUser
            // 
            this.PictureUser.Image = global::InvAc.Properties.Resources.User;
            this.PictureUser.Location = new System.Drawing.Point(0, 160);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(64, 55);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureUser.TabIndex = 11;
            this.PictureUser.TabStop = false;
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegistration.Font = new System.Drawing.Font("Century", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegistration.ForeColor = System.Drawing.Color.White;
            this.ButtonRegistration.Location = new System.Drawing.Point(0, 380);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(380, 70);
            this.ButtonRegistration.TabIndex = 5;
            this.ButtonRegistration.Text = "Создать";
            this.ButtonRegistration.UseVisualStyleBackColor = false;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxPassword.Font = new System.Drawing.Font("Century", 24F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.TextBoxPassword.Location = new System.Drawing.Point(70, 279);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(300, 56);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.MouseHover += new System.EventHandler(this.TextBoxPassword_MouseHover);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxLogin.Font = new System.Drawing.Font("Century", 24F);
            this.TextBoxLogin.ForeColor = System.Drawing.Color.White;
            this.TextBoxLogin.Location = new System.Drawing.Point(70, 160);
            this.TextBoxLogin.Multiline = true;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(298, 56);
            this.TextBoxLogin.TabIndex = 3;
            this.TextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxLogin.MouseHover += new System.EventHandler(this.TextBoxLogin_MouseHover);
            // 
            // PictureOpenEye
            // 
            this.PictureOpenEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureOpenEye.Image = global::InvAc.Properties.Resources.CloseEye;
            this.PictureOpenEye.Location = new System.Drawing.Point(335, 238);
            this.PictureOpenEye.Name = "PictureOpenEye";
            this.PictureOpenEye.Size = new System.Drawing.Size(35, 35);
            this.PictureOpenEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOpenEye.TabIndex = 13;
            this.PictureOpenEye.TabStop = false;
            this.PictureOpenEye.Click += new System.EventHandler(this.PictureOpenEye_Click);
            this.PictureOpenEye.MouseLeave += new System.EventHandler(this.PictureOpenEye_MouseLeave);
            this.PictureOpenEye.MouseHover += new System.EventHandler(this.PictureOpenEye_MouseHover);
            this.PictureOpenEye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureOpenEye_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.LeftBack);
            this.panel2.Controls.Add(this.PictureExit);
            this.panel2.Controls.Add(this.PictureKey);
            this.panel2.Controls.Add(this.Registrext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 100);
            this.panel2.TabIndex = 1;
            // 
            // LeftBack
            // 
            this.LeftBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftBack.Image = global::InvAc.Properties.Resources.Left;
            this.LeftBack.Location = new System.Drawing.Point(0, 0);
            this.LeftBack.Name = "LeftBack";
            this.LeftBack.Size = new System.Drawing.Size(35, 35);
            this.LeftBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftBack.TabIndex = 24;
            this.LeftBack.TabStop = false;
            this.LeftBack.Click += new System.EventHandler(this.LeftBack_Click);
            this.LeftBack.MouseLeave += new System.EventHandler(this.LeftBack_MouseLeave);
            this.LeftBack.MouseHover += new System.EventHandler(this.LeftBack_MouseHover);
            this.LeftBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBack_MouseMove);
            // 
            // PictureExit
            // 
            this.PictureExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureExit.Image = global::InvAc.Properties.Resources.Exit;
            this.PictureExit.Location = new System.Drawing.Point(345, 0);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(35, 35);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 23;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            this.PictureExit.MouseLeave += new System.EventHandler(this.PictureExit_MouseLeave);
            this.PictureExit.MouseHover += new System.EventHandler(this.PictureExit_MouseHover);
            this.PictureExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureExit_MouseMove);
            // 
            // PictureKey
            // 
            this.PictureKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureKey.Image = global::InvAc.Properties.Resources.NewUser;
            this.PictureKey.Location = new System.Drawing.Point(3, 28);
            this.PictureKey.Name = "PictureKey";
            this.PictureKey.Size = new System.Drawing.Size(52, 69);
            this.PictureKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureKey.TabIndex = 22;
            this.PictureKey.TabStop = false;
            // 
            // Registrext
            // 
            this.Registrext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Registrext.Font = new System.Drawing.Font("Century", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrext.ForeColor = System.Drawing.Color.White;
            this.Registrext.Location = new System.Drawing.Point(0, 0);
            this.Registrext.Name = "Registrext";
            this.Registrext.Size = new System.Drawing.Size(380, 100);
            this.Registrext.TabIndex = 1;
            this.Registrext.Text = "Регистрация";
            this.Registrext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Registrext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registrext_MouseDown);
            this.Registrext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registrext_MouseMove);
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RegistrPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrForm";
            this.Load += new System.EventHandler(this.RegistrForm_Load);
            this.RegistrPanel.ResumeLayout(false);
            this.RegistrPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCloseEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOpenEye)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegistrPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Registrext;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Button ButtonRegistration;
        private System.Windows.Forms.PictureBox PictureCloseEye;
        private System.Windows.Forms.PictureBox PictureOpenEye;
        private System.Windows.Forms.PictureBox PicturePassword;
        private System.Windows.Forms.PictureBox PictureUser;
        private System.Windows.Forms.PictureBox PictureClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureKey;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.PictureBox LeftBack;
    }
}