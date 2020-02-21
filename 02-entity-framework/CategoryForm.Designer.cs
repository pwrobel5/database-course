namespace BD_Entity
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.categoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.categoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.switchModeButton = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.numberOfUnitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteFromOrder = new System.Windows.Forms.Button();
            this.orderDGVOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDGVProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDGVNumberOfUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDGVCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodDGVProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDGVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDGVUnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDGVCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDGVUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingNavigator)).BeginInit();
            this.categoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfUnitsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryBindingNavigator
            // 
            this.categoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoryBindingNavigator.BindingSource = this.categoryBindingSource;
            this.categoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.categoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoryBindingNavigatorSaveItem});
            this.categoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoryBindingNavigator.Name = "categoryBindingNavigator";
            this.categoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoryBindingNavigator.Size = new System.Drawing.Size(1073, 27);
            this.categoryBindingNavigator.TabIndex = 0;
            this.categoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
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
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // categoryBindingNavigatorSaveItem
            // 
            this.categoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryBindingNavigatorSaveItem.Enabled = false;
            this.categoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryBindingNavigatorSaveItem.Image")));
            this.categoryBindingNavigatorSaveItem.Name = "categoryBindingNavigatorSaveItem";
            this.categoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.categoryBindingNavigatorSaveItem.Text = "Zapisz dane";
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(0, 32);
            this.categoryDataGridView.MultiSelect = false;
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowHeadersWidth = 51;
            this.categoryDataGridView.RowTemplate.Height = 24;
            this.categoryDataGridView.Size = new System.Drawing.Size(1062, 186);
            this.categoryDataGridView.TabIndex = 1;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.handleCategorySelection);
            this.categoryDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.handleCategorySelection);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 227);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 27);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodDGVProductID,
            this.prodDGVName,
            this.prodDGVUnitsInStock,
            this.prodDGVCategoryID,
            this.prodDGVUnitPrice});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(0, 267);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(1062, 182);
            this.productDataGridView.TabIndex = 3;
            this.productDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.productDataGridView_DefaultValuesNeeded);
            // 
            // switchModeButton
            // 
            this.switchModeButton.Location = new System.Drawing.Point(145, 227);
            this.switchModeButton.Name = "switchModeButton";
            this.switchModeButton.Size = new System.Drawing.Size(141, 27);
            this.switchModeButton.TabIndex = 4;
            this.switchModeButton.Text = "Edit mode";
            this.switchModeButton.UseVisualStyleBackColor = true;
            this.switchModeButton.Click += new System.EventHandler(this.switchModeButton_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDGVOrderID,
            this.orderDGVProductID,
            this.orderDGVNumberOfUnits,
            this.orderDGVCompanyName});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(-3, 501);
            this.orderDataGridView.MultiSelect = false;
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 24;
            this.orderDataGridView.Size = new System.Drawing.Size(1065, 177);
            this.orderDataGridView.TabIndex = 5;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(253, 465);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(127, 28);
            this.addToOrderButton.TabIndex = 6;
            this.addToOrderButton.Text = "Add to order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Location = new System.Drawing.Point(806, 706);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(107, 34);
            this.makeOrderButton.TabIndex = 7;
            this.makeOrderButton.Text = "Order";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(860, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(982, 684);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(46, 17);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "label2";
            // 
            // numberOfUnitsUpDown
            // 
            this.numberOfUnitsUpDown.Location = new System.Drawing.Point(127, 465);
            this.numberOfUnitsUpDown.Name = "numberOfUnitsUpDown";
            this.numberOfUnitsUpDown.Size = new System.Drawing.Size(120, 22);
            this.numberOfUnitsUpDown.TabIndex = 10;
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(919, 706);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(109, 34);
            this.cancelOrderButton.TabIndex = 11;
            this.cancelOrderButton.Text = "Cancel";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of units:";
            // 
            // deleteFromOrder
            // 
            this.deleteFromOrder.Location = new System.Drawing.Point(12, 684);
            this.deleteFromOrder.Name = "deleteFromOrder";
            this.deleteFromOrder.Size = new System.Drawing.Size(138, 29);
            this.deleteFromOrder.TabIndex = 13;
            this.deleteFromOrder.Text = "Delete from order";
            this.deleteFromOrder.UseVisualStyleBackColor = true;
            this.deleteFromOrder.Click += new System.EventHandler(this.deleteFromOrder_Click);
            // 
            // orderDGVOrderID
            // 
            this.orderDGVOrderID.DataPropertyName = "OrderID";
            this.orderDGVOrderID.HeaderText = "OrderID";
            this.orderDGVOrderID.MinimumWidth = 6;
            this.orderDGVOrderID.Name = "orderDGVOrderID";
            this.orderDGVOrderID.ReadOnly = true;
            this.orderDGVOrderID.Width = 125;
            // 
            // orderDGVProductID
            // 
            this.orderDGVProductID.DataPropertyName = "ProductID";
            this.orderDGVProductID.HeaderText = "ProductID";
            this.orderDGVProductID.MinimumWidth = 6;
            this.orderDGVProductID.Name = "orderDGVProductID";
            this.orderDGVProductID.Width = 125;
            // 
            // orderDGVNumberOfUnits
            // 
            this.orderDGVNumberOfUnits.DataPropertyName = "NumberOfUnits";
            this.orderDGVNumberOfUnits.HeaderText = "NumberOfUnits";
            this.orderDGVNumberOfUnits.MinimumWidth = 6;
            this.orderDGVNumberOfUnits.Name = "orderDGVNumberOfUnits";
            this.orderDGVNumberOfUnits.Width = 125;
            // 
            // orderDGVCompanyName
            // 
            this.orderDGVCompanyName.DataPropertyName = "CompanyName";
            this.orderDGVCompanyName.HeaderText = "CompanyName";
            this.orderDGVCompanyName.MinimumWidth = 6;
            this.orderDGVCompanyName.Name = "orderDGVCompanyName";
            this.orderDGVCompanyName.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(BD_Entity.Order);
            // 
            // prodDGVProductID
            // 
            this.prodDGVProductID.DataPropertyName = "ProductID";
            this.prodDGVProductID.HeaderText = "ProductID";
            this.prodDGVProductID.MinimumWidth = 6;
            this.prodDGVProductID.Name = "prodDGVProductID";
            this.prodDGVProductID.ReadOnly = true;
            this.prodDGVProductID.Width = 125;
            // 
            // prodDGVName
            // 
            this.prodDGVName.DataPropertyName = "Name";
            this.prodDGVName.HeaderText = "Name";
            this.prodDGVName.MinimumWidth = 6;
            this.prodDGVName.Name = "prodDGVName";
            this.prodDGVName.Width = 125;
            // 
            // prodDGVUnitsInStock
            // 
            this.prodDGVUnitsInStock.DataPropertyName = "UnitsInStock";
            this.prodDGVUnitsInStock.HeaderText = "UnitsInStock";
            this.prodDGVUnitsInStock.MinimumWidth = 6;
            this.prodDGVUnitsInStock.Name = "prodDGVUnitsInStock";
            this.prodDGVUnitsInStock.Width = 125;
            // 
            // prodDGVCategoryID
            // 
            this.prodDGVCategoryID.DataPropertyName = "CategoryID";
            this.prodDGVCategoryID.HeaderText = "CategoryID";
            this.prodDGVCategoryID.MinimumWidth = 6;
            this.prodDGVCategoryID.Name = "prodDGVCategoryID";
            this.prodDGVCategoryID.ReadOnly = true;
            this.prodDGVCategoryID.Width = 125;
            // 
            // prodDGVUnitPrice
            // 
            this.prodDGVUnitPrice.DataPropertyName = "UnitPrice";
            this.prodDGVUnitPrice.HeaderText = "UnitPrice";
            this.prodDGVUnitPrice.MinimumWidth = 6;
            this.prodDGVUnitPrice.Name = "prodDGVUnitPrice";
            this.prodDGVUnitPrice.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BD_Entity.Product);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(BD_Entity.Category);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 750);
            this.Controls.Add(this.deleteFromOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.numberOfUnitsUpDown);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.switchModeButton);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.categoryBindingNavigator);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "CategoryForm";
            this.Text = "Category Form";
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingNavigator)).EndInit();
            this.categoryBindingNavigator.ResumeLayout(false);
            this.categoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfUnitsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingNavigator categoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button switchModeButton;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.NumericUpDown numberOfUnitsUpDown;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteFromOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDGVProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDGVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDGVUnitsInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDGVCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDGVUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDGVOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDGVProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDGVNumberOfUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDGVCompanyName;
    }
}