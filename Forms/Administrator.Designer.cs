namespace InvAc.Forms
{
    partial class Administrator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label login_userLabel;
            System.Windows.Forms.Label password_userLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label is_adminLabel;
            System.Windows.Forms.Label postLabel;
            System.Windows.Forms.Label surNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.LeftBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vedenie_UchetaDataSet1 = new InvAc.Vedenie_UchetaDataSet1();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerTableAdapter = new InvAc.Vedenie_UchetaDataSet1TableAdapters.registerTableAdapter();
            this.tableAdapterManager = new InvAc.Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager();
            this.registerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDeleteAccount = new System.Windows.Forms.Button();
            this.login_userTextBox = new System.Windows.Forms.TextBox();
            this.password_userTextBox = new System.Windows.Forms.TextBox();
            this.ButtonADDAccount = new System.Windows.Forms.Button();
            this.registerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.is_adminCheckBox = new System.Windows.Forms.CheckBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            login_userLabel = new System.Windows.Forms.Label();
            password_userLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            is_adminLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            surNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenie_UchetaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingNavigator)).BeginInit();
            this.registerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_userLabel
            // 
            login_userLabel.AutoSize = true;
            login_userLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            login_userLabel.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            login_userLabel.ForeColor = System.Drawing.Color.White;
            login_userLabel.Location = new System.Drawing.Point(7, 9);
            login_userLabel.Name = "login_userLabel";
            login_userLabel.Size = new System.Drawing.Size(181, 23);
            login_userLabel.TabIndex = 13;
            login_userLabel.Text = "Логин аккаунта";
            // 
            // password_userLabel
            // 
            password_userLabel.AutoSize = true;
            password_userLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            password_userLabel.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            password_userLabel.ForeColor = System.Drawing.Color.White;
            password_userLabel.Location = new System.Drawing.Point(7, 47);
            password_userLabel.Name = "password_userLabel";
            password_userLabel.Size = new System.Drawing.Size(223, 23);
            password_userLabel.TabIndex = 15;
            password_userLabel.Text = "Пароль от аккаунта";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            nameLabel.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(621, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(56, 23);
            nameLabel.TabIndex = 35;
            nameLabel.Text = "Имя";
            // 
            // is_adminLabel
            // 
            is_adminLabel.AutoSize = true;
            is_adminLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            is_adminLabel.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            is_adminLabel.ForeColor = System.Drawing.Color.White;
            is_adminLabel.Location = new System.Drawing.Point(7, 84);
            is_adminLabel.Name = "is_adminLabel";
            is_adminLabel.Size = new System.Drawing.Size(253, 23);
            is_adminLabel.TabIndex = 26;
            is_adminLabel.Text = "Права администратора";
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            postLabel.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            postLabel.ForeColor = System.Drawing.Color.White;
            postLabel.Location = new System.Drawing.Point(621, 84);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(126, 23);
            postLabel.TabIndex = 39;
            postLabel.Text = "Должность";
            // 
            // surNameLabel
            // 
            surNameLabel.AutoSize = true;
            surNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            surNameLabel.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            surNameLabel.ForeColor = System.Drawing.Color.White;
            surNameLabel.Location = new System.Drawing.Point(621, 47);
            surNameLabel.Name = "surNameLabel";
            surNameLabel.Size = new System.Drawing.Size(107, 23);
            surNameLabel.TabIndex = 37;
            surNameLabel.Text = "Фамилия";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.PictureExit);
            this.panel1.Controls.Add(this.LeftBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
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
            this.PictureExit.Location = new System.Drawing.Point(1507, 0);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(35, 35);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 27;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            this.PictureExit.MouseLeave += new System.EventHandler(this.PictureExit_MouseLeave);
            this.PictureExit.MouseHover += new System.EventHandler(this.PictureExit_MouseHover);
            this.PictureExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureExit_MouseMove);
            // 
            // LeftBack
            // 
            this.LeftBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftBack.Image = global::InvAc.Properties.Resources.Left;
            this.LeftBack.Location = new System.Drawing.Point(0, 0);
            this.LeftBack.Name = "LeftBack";
            this.LeftBack.Size = new System.Drawing.Size(35, 35);
            this.LeftBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftBack.TabIndex = 26;
            this.LeftBack.TabStop = false;
            this.LeftBack.Click += new System.EventHandler(this.LeftBack_Click);
            this.LeftBack.MouseLeave += new System.EventHandler(this.LeftBack_MouseLeave);
            this.LeftBack.MouseHover += new System.EventHandler(this.LeftBack_MouseHover);
            this.LeftBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBack_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1542, 100);
            this.label1.TabIndex = 5;
            this.label1.Text = "Управление\r\n аккаунтами";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vedenie_UchetaDataSet1
            // 
            this.vedenie_UchetaDataSet1.DataSetName = "Vedenie_UchetaDataSet1";
            this.vedenie_UchetaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.vedenie_UchetaDataSet1;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DefectiveInventory_InventoryTableAdapter = null;
            this.tableAdapterManager.DefectiveInventoryTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.Purchase_UserTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.registerTableAdapter = this.registerTableAdapter;
            this.tableAdapterManager.UpdateOrder = InvAc.Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registerBindingNavigator
            // 
            this.registerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registerBindingNavigator.BindingSource = this.registerBindingSource;
            this.registerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.registerBindingNavigatorSaveItem});
            this.registerBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.registerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registerBindingNavigator.Name = "registerBindingNavigator";
            this.registerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registerBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.registerBindingNavigator.TabIndex = 1;
            this.registerBindingNavigator.Text = "bindingNavigator1";
            this.registerBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // registerBindingNavigatorSaveItem
            // 
            this.registerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registerBindingNavigatorSaveItem.Image")));
            this.registerBindingNavigatorSaveItem.Name = "registerBindingNavigatorSaveItem";
            this.registerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.registerBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(1272, 9);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(126, 67);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Сохранить изменения";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDeleteAccount
            // 
            this.ButtonDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteAccount.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteAccount.Location = new System.Drawing.Point(1140, 9);
            this.ButtonDeleteAccount.Name = "ButtonDeleteAccount";
            this.ButtonDeleteAccount.Size = new System.Drawing.Size(126, 67);
            this.ButtonDeleteAccount.TabIndex = 11;
            this.ButtonDeleteAccount.Text = "Удалить аккаунт";
            this.ButtonDeleteAccount.UseVisualStyleBackColor = false;
            this.ButtonDeleteAccount.Click += new System.EventHandler(this.ButtonDeleteAccount_Click);
            // 
            // login_userTextBox
            // 
            this.login_userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.login_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "login_user", true));
            this.login_userTextBox.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.login_userTextBox.ForeColor = System.Drawing.Color.White;
            this.login_userTextBox.Location = new System.Drawing.Point(257, 9);
            this.login_userTextBox.Name = "login_userTextBox";
            this.login_userTextBox.Size = new System.Drawing.Size(358, 32);
            this.login_userTextBox.TabIndex = 14;
            // 
            // password_userTextBox
            // 
            this.password_userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.password_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "password_user", true));
            this.password_userTextBox.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.password_userTextBox.ForeColor = System.Drawing.Color.White;
            this.password_userTextBox.Location = new System.Drawing.Point(257, 46);
            this.password_userTextBox.Name = "password_userTextBox";
            this.password_userTextBox.Size = new System.Drawing.Size(358, 32);
            this.password_userTextBox.TabIndex = 16;
            // 
            // ButtonADDAccount
            // 
            this.ButtonADDAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonADDAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonADDAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonADDAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonADDAccount.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonADDAccount.ForeColor = System.Drawing.Color.White;
            this.ButtonADDAccount.Location = new System.Drawing.Point(1404, 9);
            this.ButtonADDAccount.Name = "ButtonADDAccount";
            this.ButtonADDAccount.Size = new System.Drawing.Size(126, 67);
            this.ButtonADDAccount.TabIndex = 19;
            this.ButtonADDAccount.Text = "Создать аккаунт";
            this.ButtonADDAccount.UseVisualStyleBackColor = false;
            this.ButtonADDAccount.Click += new System.EventHandler(this.ButtonADDAccount_Click);
            // 
            // registerDataGridView
            // 
            this.registerDataGridView.AllowUserToResizeColumns = false;
            this.registerDataGridView.AllowUserToResizeRows = false;
            this.registerDataGridView.AutoGenerateColumns = false;
            this.registerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.registerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.registerDataGridView.DataSource = this.registerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registerDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.registerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerDataGridView.EnableHeadersVisualStyles = false;
            this.registerDataGridView.GridColor = System.Drawing.Color.White;
            this.registerDataGridView.Location = new System.Drawing.Point(0, 100);
            this.registerDataGridView.Name = "registerDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.registerDataGridView.RowHeadersVisible = false;
            this.registerDataGridView.RowHeadersWidth = 51;
            this.registerDataGridView.RowTemplate.Height = 24;
            this.registerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registerDataGridView.Size = new System.Drawing.Size(1542, 882);
            this.registerDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "login_user";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password_user";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SurName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Post";
            this.dataGridViewTextBoxColumn6.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "is_admin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Права администратора";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(765, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(356, 32);
            this.nameTextBox.TabIndex = 36;
            // 
            // is_adminCheckBox
            // 
            this.is_adminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registerBindingSource, "is_admin", true));
            this.is_adminCheckBox.Location = new System.Drawing.Point(427, 87);
            this.is_adminCheckBox.Name = "is_adminCheckBox";
            this.is_adminCheckBox.Size = new System.Drawing.Size(18, 24);
            this.is_adminCheckBox.TabIndex = 27;
            this.is_adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // postTextBox
            // 
            this.postTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "Post", true));
            this.postTextBox.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.postTextBox.ForeColor = System.Drawing.Color.White;
            this.postTextBox.Location = new System.Drawing.Point(765, 82);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(356, 32);
            this.postTextBox.TabIndex = 40;
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.surNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "SurName", true));
            this.surNameTextBox.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.surNameTextBox.ForeColor = System.Drawing.Color.White;
            this.surNameTextBox.Location = new System.Drawing.Point(765, 44);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(356, 32);
            this.surNameTextBox.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.ButtonADDAccount);
            this.panel2.Controls.Add(this.ButtonSave);
            this.panel2.Controls.Add(this.surNameTextBox);
            this.panel2.Controls.Add(this.ButtonDeleteAccount);
            this.panel2.Controls.Add(surNameLabel);
            this.panel2.Controls.Add(login_userLabel);
            this.panel2.Controls.Add(this.is_adminCheckBox);
            this.panel2.Controls.Add(nameLabel);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(password_userLabel);
            this.panel2.Controls.Add(postLabel);
            this.panel2.Controls.Add(this.login_userTextBox);
            this.panel2.Controls.Add(this.password_userTextBox);
            this.panel2.Controls.Add(this.postTextBox);
            this.panel2.Controls.Add(is_adminLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 982);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 120);
            this.panel2.TabIndex = 41;
            // 
            // Administrator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1542, 1102);
            this.Controls.Add(this.registerDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.registerBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenie_UchetaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingNavigator)).EndInit();
            this.registerBindingNavigator.ResumeLayout(false);
            this.registerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Vedenie_UchetaDataSet1 vedenie_UchetaDataSet1;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private Vedenie_UchetaDataSet1TableAdapters.registerTableAdapter registerTableAdapter;
        private Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton registerBindingNavigatorSaveItem;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDeleteAccount;
        private System.Windows.Forms.PictureBox LeftBack;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.TextBox login_userTextBox;
        private System.Windows.Forms.TextBox password_userTextBox;
        private System.Windows.Forms.Button ButtonADDAccount;
        private System.Windows.Forms.DataGridView registerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox is_adminCheckBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}