namespace InvAc.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAdmin = new System.Windows.Forms.Button();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.PictureExitAccount = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenuText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonProvider = new System.Windows.Forms.Button();
            this.ButtonDefectiveInventory = new System.Windows.Forms.Button();
            this.ButtonInventory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExitAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.PictureExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonAdmin);
            this.panel1.Controls.Add(this.TextBoxStatus);
            this.panel1.Controls.Add(this.PictureExitAccount);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MainMenuText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 100);
            this.panel1.TabIndex = 0;
            // 
            // PictureExit
            // 
            this.PictureExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureExit.Image = global::InvAc.Properties.Resources.Exit;
            this.PictureExit.Location = new System.Drawing.Point(1504, 0);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(35, 35);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 23;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            this.PictureExit.MouseLeave += new System.EventHandler(this.PictureExit_MouseLeave);
            this.PictureExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureExit_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1136, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Текущий пользователь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAdmin
            // 
            this.ButtonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.ButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdmin.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.ButtonAdmin.Location = new System.Drawing.Point(135, 4);
            this.ButtonAdmin.Name = "ButtonAdmin";
            this.ButtonAdmin.Size = new System.Drawing.Size(340, 34);
            this.ButtonAdmin.TabIndex = 9;
            this.ButtonAdmin.Text = "Управление аккаунтами";
            this.ButtonAdmin.UseVisualStyleBackColor = false;
            this.ButtonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxStatus.Font = new System.Drawing.Font("Century", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxStatus.ForeColor = System.Drawing.Color.White;
            this.TextBoxStatus.Location = new System.Drawing.Point(1127, 34);
            this.TextBoxStatus.Multiline = true;
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.ReadOnly = true;
            this.TextBoxStatus.Size = new System.Drawing.Size(330, 34);
            this.TextBoxStatus.TabIndex = 8;
            this.TextBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureExitAccount
            // 
            this.PictureExitAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureExitAccount.Image = global::InvAc.Properties.Resources.ExitAccount;
            this.PictureExitAccount.Location = new System.Drawing.Point(1463, 3);
            this.PictureExitAccount.Name = "PictureExitAccount";
            this.PictureExitAccount.Size = new System.Drawing.Size(35, 35);
            this.PictureExitAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExitAccount.TabIndex = 18;
            this.PictureExitAccount.TabStop = false;
            this.PictureExitAccount.Click += new System.EventHandler(this.PictureExitAccount_Click);
            this.PictureExitAccount.MouseLeave += new System.EventHandler(this.PictureExitAccount_MouseLeave);
            this.PictureExitAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureExitAccount_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuText
            // 
            this.MainMenuText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuText.Font = new System.Drawing.Font("Century", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuText.ForeColor = System.Drawing.Color.White;
            this.MainMenuText.Location = new System.Drawing.Point(0, 0);
            this.MainMenuText.Name = "MainMenuText";
            this.MainMenuText.Size = new System.Drawing.Size(1542, 100);
            this.MainMenuText.TabIndex = 1;
            this.MainMenuText.Text = "Главное меню";
            this.MainMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainMenuText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuText_MouseDown);
            this.MainMenuText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenuText_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ButtonProvider);
            this.panel2.Controls.Add(this.ButtonDefectiveInventory);
            this.panel2.Controls.Add(this.ButtonInventory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 1002);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 902);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1542, 100);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(527, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 90);
            this.button1.TabIndex = 7;
            this.button1.Text = "Создание накладной";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonProvider
            // 
            this.ButtonProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProvider.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonProvider.ForeColor = System.Drawing.Color.White;
            this.ButtonProvider.Location = new System.Drawing.Point(527, 330);
            this.ButtonProvider.Name = "ButtonProvider";
            this.ButtonProvider.Size = new System.Drawing.Size(517, 90);
            this.ButtonProvider.TabIndex = 6;
            this.ButtonProvider.Text = "Поставщики";
            this.ButtonProvider.UseVisualStyleBackColor = false;
            this.ButtonProvider.Click += new System.EventHandler(this.ButtonProvider_Click);
            // 
            // ButtonDefectiveInventory
            // 
            this.ButtonDefectiveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonDefectiveInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDefectiveInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonDefectiveInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDefectiveInventory.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDefectiveInventory.ForeColor = System.Drawing.Color.White;
            this.ButtonDefectiveInventory.Location = new System.Drawing.Point(527, 230);
            this.ButtonDefectiveInventory.Name = "ButtonDefectiveInventory";
            this.ButtonDefectiveInventory.Size = new System.Drawing.Size(517, 90);
            this.ButtonDefectiveInventory.TabIndex = 5;
            this.ButtonDefectiveInventory.Text = "Бракованый инвентарь";
            this.ButtonDefectiveInventory.UseVisualStyleBackColor = false;
            this.ButtonDefectiveInventory.Click += new System.EventHandler(this.ButtonDefectiveInventory_Click);
            // 
            // ButtonInventory
            // 
            this.ButtonInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInventory.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInventory.ForeColor = System.Drawing.Color.White;
            this.ButtonInventory.Location = new System.Drawing.Point(527, 130);
            this.ButtonInventory.Name = "ButtonInventory";
            this.ButtonInventory.Size = new System.Drawing.Size(517, 90);
            this.ButtonInventory.TabIndex = 4;
            this.ButtonInventory.Text = "Инвентарь";
            this.ButtonInventory.UseVisualStyleBackColor = false;
            this.ButtonInventory.Click += new System.EventHandler(this.ButtonInventory_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1542, 1102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExitAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MainMenuText;
        private System.Windows.Forms.Button ButtonProvider;
        private System.Windows.Forms.Button ButtonDefectiveInventory;
        private System.Windows.Forms.Button ButtonInventory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PictureExitAccount;
        private System.Windows.Forms.Button ButtonAdmin;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxStatus;
        private System.Windows.Forms.Panel panel3;
    }
}