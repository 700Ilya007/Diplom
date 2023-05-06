namespace InvAc.Forms
{
    partial class DefectiveInventory
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
            System.Windows.Forms.Label nameDefectiveInventoryLabel;
            System.Windows.Forms.Label reasonOfDefectiveLabel;
            System.Windows.Forms.Label numberOfDefectiveInventoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectiveInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.defectiveInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedenie_UchetaDataSet1 = new InvAc.Vedenie_UchetaDataSet1();
            this.defectiveInventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.defectiveInventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.defectiveInventoryTableAdapter = new InvAc.Vedenie_UchetaDataSet1TableAdapters.DefectiveInventoryTableAdapter();
            this.tableAdapterManager = new InvAc.Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxReasonOfDefective = new System.Windows.Forms.TextBox();
            this.TextBoxNumberOfDefectiveInventory = new System.Windows.Forms.TextBox();
            this.TextBoxNameDefectiveInventory = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonADD = new System.Windows.Forms.Button();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.TextBoxID_DefectiveInventory = new System.Windows.Forms.TextBox();
            this.DGVDefectiveInventory = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.экспортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftBack = new System.Windows.Forms.PictureBox();
            this.PictureRefreshTable = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            nameDefectiveInventoryLabel = new System.Windows.Forms.Label();
            reasonOfDefectiveLabel = new System.Windows.Forms.Label();
            numberOfDefectiveInventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.defectiveInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenie_UchetaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectiveInventoryBindingNavigator)).BeginInit();
            this.defectiveInventoryBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDefectiveInventory)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRefreshTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameDefectiveInventoryLabel
            // 
            nameDefectiveInventoryLabel.AutoSize = true;
            nameDefectiveInventoryLabel.Font = new System.Drawing.Font("Century", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            nameDefectiveInventoryLabel.ForeColor = System.Drawing.Color.White;
            nameDefectiveInventoryLabel.Location = new System.Drawing.Point(4, 5);
            nameDefectiveInventoryLabel.Name = "nameDefectiveInventoryLabel";
            nameDefectiveInventoryLabel.Size = new System.Drawing.Size(332, 21);
            nameDefectiveInventoryLabel.TabIndex = 9;
            nameDefectiveInventoryLabel.Text = "Название бракованного инвентаря";
            // 
            // reasonOfDefectiveLabel
            // 
            reasonOfDefectiveLabel.AutoSize = true;
            reasonOfDefectiveLabel.Font = new System.Drawing.Font("Century", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            reasonOfDefectiveLabel.ForeColor = System.Drawing.Color.White;
            reasonOfDefectiveLabel.Location = new System.Drawing.Point(3, 69);
            reasonOfDefectiveLabel.Name = "reasonOfDefectiveLabel";
            reasonOfDefectiveLabel.Size = new System.Drawing.Size(206, 21);
            reasonOfDefectiveLabel.TabIndex = 5;
            reasonOfDefectiveLabel.Text = "Причина бракования";
            // 
            // numberOfDefectiveInventoryLabel
            // 
            numberOfDefectiveInventoryLabel.AutoSize = true;
            numberOfDefectiveInventoryLabel.Font = new System.Drawing.Font("Century", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            numberOfDefectiveInventoryLabel.ForeColor = System.Drawing.Color.White;
            numberOfDefectiveInventoryLabel.Location = new System.Drawing.Point(3, 37);
            numberOfDefectiveInventoryLabel.Name = "numberOfDefectiveInventoryLabel";
            numberOfDefectiveInventoryLabel.Size = new System.Drawing.Size(350, 21);
            numberOfDefectiveInventoryLabel.TabIndex = 3;
            numberOfDefectiveInventoryLabel.Text = "Количество бракованного инвентаря";
            // 
            // defectiveInventoryBindingSource
            // 
            this.defectiveInventoryBindingSource.DataMember = "DefectiveInventory";
            this.defectiveInventoryBindingSource.DataSource = this.vedenie_UchetaDataSet1;
            // 
            // vedenie_UchetaDataSet1
            // 
            this.vedenie_UchetaDataSet1.DataSetName = "Vedenie_UchetaDataSet1";
            this.vedenie_UchetaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // defectiveInventoryBindingNavigator
            // 
            this.defectiveInventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.defectiveInventoryBindingNavigator.BindingSource = this.defectiveInventoryBindingSource;
            this.defectiveInventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.defectiveInventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.defectiveInventoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.defectiveInventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.defectiveInventoryBindingNavigatorSaveItem});
            this.defectiveInventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.defectiveInventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.defectiveInventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.defectiveInventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.defectiveInventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.defectiveInventoryBindingNavigator.Name = "defectiveInventoryBindingNavigator";
            this.defectiveInventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.defectiveInventoryBindingNavigator.Size = new System.Drawing.Size(1542, 27);
            this.defectiveInventoryBindingNavigator.TabIndex = 3;
            this.defectiveInventoryBindingNavigator.Text = "bindingNavigator1";
            this.defectiveInventoryBindingNavigator.Visible = false;
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
            // defectiveInventoryBindingNavigatorSaveItem
            // 
            this.defectiveInventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.defectiveInventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("defectiveInventoryBindingNavigatorSaveItem.Image")));
            this.defectiveInventoryBindingNavigatorSaveItem.Name = "defectiveInventoryBindingNavigatorSaveItem";
            this.defectiveInventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.defectiveInventoryBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.defectiveInventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.defectiveInventoryBindingNavigatorSaveItem_Click);
            // 
            // defectiveInventoryTableAdapter
            // 
            this.defectiveInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DefectiveInventory_InventoryTableAdapter = null;
            this.tableAdapterManager.DefectiveInventoryTableAdapter = this.defectiveInventoryTableAdapter;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.Purchase_UserTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.registerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InvAc.Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.TextBoxReasonOfDefective);
            this.panel1.Controls.Add(this.TextBoxNumberOfDefectiveInventory);
            this.panel1.Controls.Add(this.TextBoxNameDefectiveInventory);
            this.panel1.Controls.Add(this.ButtonSave);
            this.panel1.Controls.Add(numberOfDefectiveInventoryLabel);
            this.panel1.Controls.Add(reasonOfDefectiveLabel);
            this.panel1.Controls.Add(this.ButtonDelete);
            this.panel1.Controls.Add(nameDefectiveInventoryLabel);
            this.panel1.Controls.Add(this.ButtonADD);
            this.panel1.Controls.Add(this.ButtonChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1002);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 100);
            this.panel1.TabIndex = 18;
            // 
            // TextBoxReasonOfDefective
            // 
            this.TextBoxReasonOfDefective.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxReasonOfDefective.ForeColor = System.Drawing.Color.White;
            this.TextBoxReasonOfDefective.Location = new System.Drawing.Point(371, 69);
            this.TextBoxReasonOfDefective.Name = "TextBoxReasonOfDefective";
            this.TextBoxReasonOfDefective.Size = new System.Drawing.Size(629, 28);
            this.TextBoxReasonOfDefective.TabIndex = 25;
            // 
            // TextBoxNumberOfDefectiveInventory
            // 
            this.TextBoxNumberOfDefectiveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxNumberOfDefectiveInventory.ForeColor = System.Drawing.Color.White;
            this.TextBoxNumberOfDefectiveInventory.Location = new System.Drawing.Point(370, 37);
            this.TextBoxNumberOfDefectiveInventory.Name = "TextBoxNumberOfDefectiveInventory";
            this.TextBoxNumberOfDefectiveInventory.Size = new System.Drawing.Size(629, 28);
            this.TextBoxNumberOfDefectiveInventory.TabIndex = 24;
            this.TextBoxNumberOfDefectiveInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumberOfDefectiveInventory_KeyPress);
            // 
            // TextBoxNameDefectiveInventory
            // 
            this.TextBoxNameDefectiveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxNameDefectiveInventory.ForeColor = System.Drawing.Color.White;
            this.TextBoxNameDefectiveInventory.Location = new System.Drawing.Point(370, 6);
            this.TextBoxNameDefectiveInventory.Name = "TextBoxNameDefectiveInventory";
            this.TextBoxNameDefectiveInventory.Size = new System.Drawing.Size(629, 28);
            this.TextBoxNameDefectiveInventory.TabIndex = 23;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(1019, 21);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(126, 67);
            this.ButtonSave.TabIndex = 22;
            this.ButtonSave.Text = "Сохранить изменения";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(1283, 21);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(126, 67);
            this.ButtonDelete.TabIndex = 20;
            this.ButtonDelete.Text = "Удалить запись";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonADD
            // 
            this.ButtonADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonADD.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonADD.ForeColor = System.Drawing.Color.White;
            this.ButtonADD.Location = new System.Drawing.Point(1413, 21);
            this.ButtonADD.Name = "ButtonADD";
            this.ButtonADD.Size = new System.Drawing.Size(126, 67);
            this.ButtonADD.TabIndex = 19;
            this.ButtonADD.Text = "Добавить запись";
            this.ButtonADD.UseVisualStyleBackColor = false;
            this.ButtonADD.Click += new System.EventHandler(this.ButtonADD_Click);
            // 
            // ButtonChange
            // 
            this.ButtonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChange.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChange.ForeColor = System.Drawing.Color.White;
            this.ButtonChange.Location = new System.Drawing.Point(1151, 21);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(126, 67);
            this.ButtonChange.TabIndex = 21;
            this.ButtonChange.Text = "Изменить запись";
            this.ButtonChange.UseVisualStyleBackColor = false;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // TextBoxID_DefectiveInventory
            // 
            this.TextBoxID_DefectiveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.TextBoxID_DefectiveInventory.Location = new System.Drawing.Point(41, 963);
            this.TextBoxID_DefectiveInventory.Multiline = true;
            this.TextBoxID_DefectiveInventory.Name = "TextBoxID_DefectiveInventory";
            this.TextBoxID_DefectiveInventory.Size = new System.Drawing.Size(10, 10);
            this.TextBoxID_DefectiveInventory.TabIndex = 27;
            // 
            // DGVDefectiveInventory
            // 
            this.DGVDefectiveInventory.AllowUserToAddRows = false;
            this.DGVDefectiveInventory.AllowUserToDeleteRows = false;
            this.DGVDefectiveInventory.AllowUserToResizeColumns = false;
            this.DGVDefectiveInventory.AllowUserToResizeRows = false;
            this.DGVDefectiveInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDefectiveInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGVDefectiveInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDefectiveInventory.DefaultCellStyle = dataGridViewCellStyle14;
            this.DGVDefectiveInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDefectiveInventory.EnableHeadersVisualStyles = false;
            this.DGVDefectiveInventory.GridColor = System.Drawing.Color.White;
            this.DGVDefectiveInventory.Location = new System.Drawing.Point(0, 100);
            this.DGVDefectiveInventory.Name = "DGVDefectiveInventory";
            this.DGVDefectiveInventory.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDefectiveInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DGVDefectiveInventory.RowHeadersVisible = false;
            this.DGVDefectiveInventory.RowHeadersWidth = 51;
            this.DGVDefectiveInventory.RowTemplate.Height = 24;
            this.DGVDefectiveInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDefectiveInventory.Size = new System.Drawing.Size(1542, 902);
            this.DGVDefectiveInventory.TabIndex = 28;
            this.DGVDefectiveInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDefectiveInventory_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.LeftBack);
            this.panel3.Controls.Add(this.PictureRefreshTable);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TextBoxSearch);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.PictureExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1542, 100);
            this.panel3.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.toolStrip1);
            this.panel5.Location = new System.Drawing.Point(41, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 35);
            this.panel5.TabIndex = 32;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(60, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортироватьToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Image = global::InvAc.Properties.Resources.Export;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "Работа с таблицей";
            // 
            // экспортироватьToolStripMenuItem
            // 
            this.экспортироватьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.экспортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вExcelToolStripMenuItem,
            this.вWordToolStripMenuItem});
            this.экспортироватьToolStripMenuItem.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.экспортироватьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.экспортироватьToolStripMenuItem.Name = "экспортироватьToolStripMenuItem";
            this.экспортироватьToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.экспортироватьToolStripMenuItem.Text = "Экспортировать";
            // 
            // вExcelToolStripMenuItem
            // 
            this.вExcelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.вExcelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.вExcelToolStripMenuItem.Name = "вExcelToolStripMenuItem";
            this.вExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.вExcelToolStripMenuItem.Text = "В Excel";
            this.вExcelToolStripMenuItem.Click += new System.EventHandler(this.вExcelToolStripMenuItem_Click_1);
            // 
            // вWordToolStripMenuItem
            // 
            this.вWordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.вWordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.вWordToolStripMenuItem.Name = "вWordToolStripMenuItem";
            this.вWordToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.вWordToolStripMenuItem.Text = "В  Word";
            this.вWordToolStripMenuItem.Click += new System.EventHandler(this.вWordToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1218, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Поиск";
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
            // PictureRefreshTable
            // 
            this.PictureRefreshTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureRefreshTable.Image = global::InvAc.Properties.Resources.Update;
            this.PictureRefreshTable.Location = new System.Drawing.Point(1466, 0);
            this.PictureRefreshTable.Name = "PictureRefreshTable";
            this.PictureRefreshTable.Size = new System.Drawing.Size(35, 35);
            this.PictureRefreshTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureRefreshTable.TabIndex = 29;
            this.PictureRefreshTable.TabStop = false;
            this.PictureRefreshTable.Click += new System.EventHandler(this.PictureRefreshTable_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 96);
            this.label1.TabIndex = 29;
            this.label1.Text = "Бракованный\r\nинвентарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxSearch.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.White;
            this.TextBoxSearch.Location = new System.Drawing.Point(1223, 45);
            this.TextBoxSearch.Multiline = true;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(278, 35);
            this.TextBoxSearch.TabIndex = 14;
            this.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InvAc.Properties.Resources.LogoMaker;
            this.pictureBox1.Location = new System.Drawing.Point(53, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.DGVDefectiveInventory);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.TextBoxID_DefectiveInventory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 1102);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(371, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 31;
            // 
            // DefectiveInventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1542, 1102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.defectiveInventoryBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefectiveInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DefectiveInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DefectiveInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defectiveInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenie_UchetaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectiveInventoryBindingNavigator)).EndInit();
            this.defectiveInventoryBindingNavigator.ResumeLayout(false);
            this.defectiveInventoryBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDefectiveInventory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRefreshTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Vedenie_UchetaDataSet1 vedenie_UchetaDataSet1;
        private System.Windows.Forms.BindingSource defectiveInventoryBindingSource;
        private Vedenie_UchetaDataSet1TableAdapters.DefectiveInventoryTableAdapter defectiveInventoryTableAdapter;
        private Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator defectiveInventoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton defectiveInventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxID_DefectiveInventory;
        private System.Windows.Forms.TextBox TextBoxReasonOfDefective;
        private System.Windows.Forms.TextBox TextBoxNumberOfDefectiveInventory;
        private System.Windows.Forms.TextBox TextBoxNameDefectiveInventory;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonADD;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.DataGridView DGVDefectiveInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox LeftBack;
        private System.Windows.Forms.PictureBox PictureRefreshTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вWordToolStripMenuItem;
    }
}