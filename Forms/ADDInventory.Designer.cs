namespace InvAc.Forms
{
    partial class ADDInventory
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
            System.Windows.Forms.Label numberOfInventoryLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label nameInventoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDInventory));
            this.AutorizationText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftBack = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedenie_UchetaDataSet1 = new InvAc.Vedenie_UchetaDataSet1();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.inventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.inventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new InvAc.Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager();
            this.inventoryTableAdapter = new InvAc.Vedenie_UchetaDataSet1TableAdapters.InventoryTableAdapter();
            this.ButtonADD = new System.Windows.Forms.Button();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxNumberOfInventory = new System.Windows.Forms.TextBox();
            this.TextBoxNameInventory = new System.Windows.Forms.TextBox();
            numberOfInventoryLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            nameInventoryLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenie_UchetaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).BeginInit();
            this.inventoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberOfInventoryLabel
            // 
            numberOfInventoryLabel.AutoSize = true;
            numberOfInventoryLabel.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            numberOfInventoryLabel.ForeColor = System.Drawing.Color.White;
            numberOfInventoryLabel.Location = new System.Drawing.Point(0, 165);
            numberOfInventoryLabel.Name = "numberOfInventoryLabel";
            numberOfInventoryLabel.Size = new System.Drawing.Size(189, 17);
            numberOfInventoryLabel.TabIndex = 25;
            numberOfInventoryLabel.Text = "Количество инвентаря:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            priceLabel.ForeColor = System.Drawing.Color.White;
            priceLabel.Location = new System.Drawing.Point(0, 210);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(53, 17);
            priceLabel.TabIndex = 27;
            priceLabel.Text = "Цена:";
            // 
            // nameInventoryLabel
            // 
            nameInventoryLabel.AutoSize = true;
            nameInventoryLabel.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            nameInventoryLabel.ForeColor = System.Drawing.Color.White;
            nameInventoryLabel.Location = new System.Drawing.Point(0, 120);
            nameInventoryLabel.Name = "nameInventoryLabel";
            nameInventoryLabel.Size = new System.Drawing.Size(176, 17);
            nameInventoryLabel.TabIndex = 23;
            nameInventoryLabel.Text = "Название инвентаря:";
            // 
            // AutorizationText
            // 
            this.AutorizationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutorizationText.Font = new System.Drawing.Font("Century", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorizationText.ForeColor = System.Drawing.Color.White;
            this.AutorizationText.Location = new System.Drawing.Point(0, 0);
            this.AutorizationText.Name = "AutorizationText";
            this.AutorizationText.Size = new System.Drawing.Size(380, 100);
            this.AutorizationText.TabIndex = 1;
            this.AutorizationText.Text = "Добавление инвентаря";
            this.AutorizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.LeftBack);
            this.panel1.Controls.Add(this.AutorizationText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 100);
            this.panel1.TabIndex = 30;
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
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(140)))));
            this.ExitButton.Location = new System.Drawing.Point(777, 27);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(23, 21);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.Text = "X";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.vedenie_UchetaDataSet1;
            // 
            // vedenie_UchetaDataSet1
            // 
            this.vedenie_UchetaDataSet1.DataSetName = "Vedenie_UchetaDataSet1";
            this.vedenie_UchetaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // inventoryBindingNavigator
            // 
            this.inventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventoryBindingNavigator.BindingSource = this.inventoryBindingSource;
            this.inventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.inventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inventoryBindingNavigatorSaveItem});
            this.inventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventoryBindingNavigator.Name = "inventoryBindingNavigator";
            this.inventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventoryBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.inventoryBindingNavigator.TabIndex = 22;
            this.inventoryBindingNavigator.Text = "bindingNavigator1";
            this.inventoryBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // inventoryBindingNavigatorSaveItem
            // 
            this.inventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBindingNavigatorSaveItem.Image")));
            this.inventoryBindingNavigatorSaveItem.Name = "inventoryBindingNavigatorSaveItem";
            this.inventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.inventoryBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DefectiveInventory_InventoryTableAdapter = null;
            this.tableAdapterManager.DefectiveInventoryTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.Purchase_UserTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.registerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InvAc.Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonADD
            // 
            this.ButtonADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ButtonADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonADD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ButtonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonADD.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonADD.ForeColor = System.Drawing.Color.White;
            this.ButtonADD.Location = new System.Drawing.Point(0, 383);
            this.ButtonADD.Name = "ButtonADD";
            this.ButtonADD.Size = new System.Drawing.Size(380, 67);
            this.ButtonADD.TabIndex = 21;
            this.ButtonADD.Text = "Добавить запись";
            this.ButtonADD.UseVisualStyleBackColor = false;
            this.ButtonADD.Click += new System.EventHandler(this.ButtonADD_Click);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxPrice.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxPrice.ForeColor = System.Drawing.Color.White;
            this.TextBoxPrice.Location = new System.Drawing.Point(205, 210);
            this.TextBoxPrice.Multiline = true;
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(165, 30);
            this.TextBoxPrice.TabIndex = 28;
            this.TextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // TextBoxNumberOfInventory
            // 
            this.TextBoxNumberOfInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxNumberOfInventory.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxNumberOfInventory.ForeColor = System.Drawing.Color.White;
            this.TextBoxNumberOfInventory.Location = new System.Drawing.Point(205, 165);
            this.TextBoxNumberOfInventory.Multiline = true;
            this.TextBoxNumberOfInventory.Name = "TextBoxNumberOfInventory";
            this.TextBoxNumberOfInventory.Size = new System.Drawing.Size(165, 30);
            this.TextBoxNumberOfInventory.TabIndex = 26;
            this.TextBoxNumberOfInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumberOfInventory_KeyPress);
            // 
            // TextBoxNameInventory
            // 
            this.TextBoxNameInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TextBoxNameInventory.Font = new System.Drawing.Font("Century", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxNameInventory.ForeColor = System.Drawing.Color.White;
            this.TextBoxNameInventory.Location = new System.Drawing.Point(205, 120);
            this.TextBoxNameInventory.Multiline = true;
            this.TextBoxNameInventory.Name = "TextBoxNameInventory";
            this.TextBoxNameInventory.Size = new System.Drawing.Size(166, 30);
            this.TextBoxNameInventory.TabIndex = 24;
            // 
            // ADDInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TextBoxNameInventory);
            this.Controls.Add(this.TextBoxNumberOfInventory);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.inventoryBindingNavigator);
            this.Controls.Add(numberOfInventoryLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.ButtonADD);
            this.Controls.Add(nameInventoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADDInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenie_UchetaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).EndInit();
            this.inventoryBindingNavigator.ResumeLayout(false);
            this.inventoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AutorizationText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LeftBack;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Vedenie_UchetaDataSet1 vedenie_UchetaDataSet1;
        private System.Windows.Forms.ToolStripButton inventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingNavigator inventoryBindingNavigator;
        private Vedenie_UchetaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Vedenie_UchetaDataSet1TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.Button ButtonADD;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxNumberOfInventory;
        private System.Windows.Forms.TextBox TextBoxNameInventory;
    }
}