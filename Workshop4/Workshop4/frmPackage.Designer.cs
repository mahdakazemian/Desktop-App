namespace Workshop4 {
    partial class frmPackage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.btnUpdatePkg = new System.Windows.Forms.Button();
            this.btnDeletePkg = new System.Windows.Forms.Button();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameComboBox = new System.Windows.Forms.ComboBox();
            this.productSupplierViewModelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSupplierViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.packageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.prodNameComboBox = new System.Windows.Forms.ComboBox();
            this.supNameComboBox = new System.Windows.Forms.ComboBox();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(53, 312);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(156, 20);
            pkgAgencyCommissionLabel.TabIndex = 24;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(122, 269);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(89, 20);
            pkgBasePriceLabel.TabIndex = 26;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(116, 360);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(93, 20);
            pkgDescLabel.TabIndex = 28;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(128, 229);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(81, 20);
            pkgEndDateLabel.TabIndex = 30;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(122, 183);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(87, 20);
            pkgStartDateLabel.TabIndex = 34;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(154, 139);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(55, 20);
            pkgNameLabel.TabIndex = 36;
            pkgNameLabel.Text = "Name:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(572, 166);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(97, 16);
            prodNameLabel.TabIndex = 39;
            prodNameLabel.Text = "Product Name:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.Location = new System.Drawing.Point(758, 166);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(101, 16);
            supNameLabel.TabIndex = 40;
            supNameLabel.Text = "Supplier Name:";
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddPkg.FlatAppearance.BorderSize = 0;
            this.btnAddPkg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnAddPkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPkg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddPkg.Location = new System.Drawing.Point(157, 593);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(135, 35);
            this.btnAddPkg.TabIndex = 22;
            this.btnAddPkg.Text = "Add Packages";
            this.btnAddPkg.UseVisualStyleBackColor = false;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // btnUpdatePkg
            // 
            this.btnUpdatePkg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePkg.FlatAppearance.BorderSize = 0;
            this.btnUpdatePkg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnUpdatePkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePkg.Location = new System.Drawing.Point(446, 593);
            this.btnUpdatePkg.Name = "btnUpdatePkg";
            this.btnUpdatePkg.Size = new System.Drawing.Size(135, 35);
            this.btnUpdatePkg.TabIndex = 23;
            this.btnUpdatePkg.Text = "Update Packages";
            this.btnUpdatePkg.UseVisualStyleBackColor = false;
            this.btnUpdatePkg.Click += new System.EventHandler(this.btnUpdatePkg_Click);
            // 
            // btnDeletePkg
            // 
            this.btnDeletePkg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeletePkg.FlatAppearance.BorderSize = 0;
            this.btnDeletePkg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnDeletePkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePkg.Location = new System.Drawing.Point(740, 593);
            this.btnDeletePkg.Name = "btnDeletePkg";
            this.btnDeletePkg.Size = new System.Drawing.Size(135, 35);
            this.btnDeletePkg.TabIndex = 24;
            this.btnDeletePkg.Text = "Delete Packages";
            this.btnDeletePkg.UseVisualStyleBackColor = false;
            this.btnDeletePkg.Click += new System.EventHandler(this.btnDeletePkg_Click);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.BackColor = System.Drawing.Color.White;
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(245, 306);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.ReadOnly = true;
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(244, 26);
            this.pkgAgencyCommissionTextBox.TabIndex = 25;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(ClassEntites.Package);
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.BackColor = System.Drawing.Color.White;
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(245, 263);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.ReadOnly = true;
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(244, 26);
            this.pkgBasePriceTextBox.TabIndex = 27;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.BackColor = System.Drawing.Color.White;
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgDescTextBox.Location = new System.Drawing.Point(245, 360);
            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.ReadOnly = true;
            this.pkgDescTextBox.Size = new System.Drawing.Size(244, 93);
            this.pkgDescTextBox.TabIndex = 29;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Enabled = false;
            this.pkgEndDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(245, 223);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(244, 26);
            this.pkgEndDateDateTimePicker.TabIndex = 31;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Enabled = false;
            this.pkgStartDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(245, 177);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(244, 26);
            this.pkgStartDateDateTimePicker.TabIndex = 35;
            // 
            // pkgNameComboBox
            // 
            this.pkgNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packageBindingSource, "PackageId", true));
            this.pkgNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pkgNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgNameComboBox.FormattingEnabled = true;
            this.pkgNameComboBox.Location = new System.Drawing.Point(245, 131);
            this.pkgNameComboBox.Name = "pkgNameComboBox";
            this.pkgNameComboBox.Size = new System.Drawing.Size(244, 28);
            this.pkgNameComboBox.TabIndex = 37;
            this.pkgNameComboBox.SelectedIndexChanged += new System.EventHandler(this.pkgNameComboBox_SelectedIndexChanged);
            // 
            // productSupplierViewModelDataGridView
            // 
            this.productSupplierViewModelDataGridView.AutoGenerateColumns = false;
            this.productSupplierViewModelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productSupplierViewModelDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.productSupplierViewModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSupplierViewModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.productSupplierViewModelDataGridView.DataSource = this.productSupplierViewModelBindingSource;
            this.productSupplierViewModelDataGridView.Location = new System.Drawing.Point(527, 223);
            this.productSupplierViewModelDataGridView.Name = "productSupplierViewModelDataGridView";
            this.productSupplierViewModelDataGridView.ReadOnly = true;
            this.productSupplierViewModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productSupplierViewModelDataGridView.Size = new System.Drawing.Size(450, 230);
            this.productSupplierViewModelDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSupplierId";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Supplier ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 104;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 92;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SuppName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // productSupplierViewModelBindingSource
            // 
            this.productSupplierViewModelBindingSource.DataSource = typeof(ClassEntites.ProductSupplierViewModel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 64);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Packages";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(ClassEntites.Supplier);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ClassEntites.Product);
            // 
            // packageBindingSource1
            // 
            this.packageBindingSource1.DataSource = typeof(ClassEntites.Package);
            // 
            // packageBindingSource2
            // 
            this.packageBindingSource2.DataSource = typeof(ClassEntites.Package);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(761, 131);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(621, 131);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 39;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prodNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameComboBox.FormattingEnabled = true;
            this.prodNameComboBox.Location = new System.Drawing.Point(575, 185);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.prodNameComboBox.TabIndex = 40;
            this.prodNameComboBox.SelectedIndexChanged += new System.EventHandler(this.prodNameComboBox_SelectedIndexChanged);
            // 
            // supNameComboBox
            // 
            this.supNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.supNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameComboBox.FormattingEnabled = true;
            this.supNameComboBox.Location = new System.Drawing.Point(761, 185);
            this.supNameComboBox.Name = "supNameComboBox";
            this.supNameComboBox.Size = new System.Drawing.Size(161, 24);
            this.supNameComboBox.TabIndex = 41;
            this.supNameComboBox.SelectedIndexChanged += new System.EventHandler(this.supNameComboBox_SelectedIndexChanged);
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 684);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameComboBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameComboBox);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productSupplierViewModelDataGridView);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameComboBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Controls.Add(this.btnDeletePkg);
            this.Controls.Add(this.btnUpdatePkg);
            this.Controls.Add(this.btnAddPkg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPackage";
            this.Text = "frmPackage";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Button btnUpdatePkg;
        private System.Windows.Forms.Button btnDeletePkg;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.ComboBox pkgNameComboBox;
        private System.Windows.Forms.BindingSource productSupplierViewModelBindingSource;
        private System.Windows.Forms.DataGridView productSupplierViewModelDataGridView;
        private System.Windows.Forms.BindingSource packageBindingSource1;
        private System.Windows.Forms.BindingSource packageBindingSource2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox prodNameComboBox;
        private System.Windows.Forms.ComboBox supNameComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}