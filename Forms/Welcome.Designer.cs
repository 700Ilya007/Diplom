namespace InvAc
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.ButtonAutorization = new System.Windows.Forms.Button();
            this.ButtonRegistr = new System.Windows.Forms.Button();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAutorization
            // 
            this.ButtonAutorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonAutorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAutorization.FlatAppearance.BorderSize = 3;
            this.ButtonAutorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonAutorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAutorization.Font = new System.Drawing.Font("Century", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAutorization.ForeColor = System.Drawing.Color.White;
            this.ButtonAutorization.Location = new System.Drawing.Point(0, 378);
            this.ButtonAutorization.Name = "ButtonAutorization";
            this.ButtonAutorization.Size = new System.Drawing.Size(190, 70);
            this.ButtonAutorization.TabIndex = 4;
            this.ButtonAutorization.Text = "Авторизация";
            this.ButtonAutorization.UseVisualStyleBackColor = false;
            this.ButtonAutorization.Click += new System.EventHandler(this.ButtonAutorization_Click);
            // 
            // ButtonRegistr
            // 
            this.ButtonRegistr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegistr.FlatAppearance.BorderSize = 3;
            this.ButtonRegistr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegistr.Font = new System.Drawing.Font("Century", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegistr.ForeColor = System.Drawing.Color.White;
            this.ButtonRegistr.Location = new System.Drawing.Point(190, 378);
            this.ButtonRegistr.Name = "ButtonRegistr";
            this.ButtonRegistr.Size = new System.Drawing.Size(190, 70);
            this.ButtonRegistr.TabIndex = 5;
            this.ButtonRegistr.Text = "Регистрация";
            this.ButtonRegistr.UseVisualStyleBackColor = false;
            this.ButtonRegistr.Click += new System.EventHandler(this.ButtonRegistr_Click);
            // 
            // PictureExit
            // 
            this.PictureExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureExit.Image = global::InvAc.Properties.Resources.Exit;
            this.PictureExit.Location = new System.Drawing.Point(345, 0);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(35, 35);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 21;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            this.PictureExit.MouseLeave += new System.EventHandler(this.PictureExit_MouseLeave);
            this.PictureExit.MouseHover += new System.EventHandler(this.PictureExit_MouseHover);
            this.PictureExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureExit_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 372);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.PictureExit);
            this.Controls.Add(this.ButtonRegistr);
            this.Controls.Add(this.ButtonAutorization);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ButtonAutorization;
        private System.Windows.Forms.Button ButtonRegistr;
        private System.Windows.Forms.PictureBox PictureExit;
    }
}