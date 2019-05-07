namespace Workshop4 {
    partial class ProductsSupplierForm {
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
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label productIdLabel1;
            System.Windows.Forms.Label supplierIdLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsSupplierForm));
            this.productsSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productSupplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.txtProdSuppId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.btnSearchProdId = new System.Windows.Forms.Button();
            this.productsSupplierDataGridViewSortByProdId = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSuppId = new System.Windows.Forms.TextBox();
            this.btnSearchSuppId = new System.Windows.Forms.Button();
            this.productsSupplierDataGridViewSortBySuppId = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdTextBoxAdd = new System.Windows.Forms.TextBox();
            this.supplierIdTextBoxAdd = new System.Windows.Forms.TextBox();
            this.btnAddProdSupp = new System.Windows.Forms.Button();
            productIdLabel = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            productIdLabel1 = new System.Windows.Forms.Label();
            supplierIdLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierDataGridViewSortByProdId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierDataGridViewSortBySuppId)).BeginInit();
            this.SuspendLayout();
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(492, 34);
            productIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(92, 20);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "Product Id";
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.BackColor = System.Drawing.Color.Transparent;
            productSupplierIdLabel.Location = new System.Drawing.Point(118, 37);
            productSupplierIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(163, 20);
            productSupplierIdLabel.TabIndex = 3;
            productSupplierIdLabel.Text = "Product Supplier Id";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(492, 94);
            supplierIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(96, 20);
            supplierIdLabel.TabIndex = 5;
            supplierIdLabel.Text = "Supplier Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 92);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(250, 40);
            label1.TabIndex = 7;
            label1.Text = "Search By Product Supplier Id\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 228);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 20);
            label2.TabIndex = 10;
            label2.Text = "Search By Product Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(783, 226);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(183, 20);
            label3.TabIndex = 13;
            label3.Text = "Search By Supplier Id";
            // 
            // productIdLabel1
            // 
            productIdLabel1.AutoSize = true;
            productIdLabel1.Location = new System.Drawing.Point(1088, 32);
            productIdLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productIdLabel1.Name = "productIdLabel1";
            productIdLabel1.Size = new System.Drawing.Size(92, 20);
            productIdLabel1.TabIndex = 17;
            productIdLabel1.Text = "Product Id";
            // 
            // supplierIdLabel1
            // 
            supplierIdLabel1.AutoSize = true;
            supplierIdLabel1.Location = new System.Drawing.Point(1088, 72);
            supplierIdLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            supplierIdLabel1.Name = "supplierIdLabel1";
            supplierIdLabel1.Size = new System.Drawing.Size(96, 20);
            supplierIdLabel1.TabIndex = 19;
            supplierIdLabel1.Text = "Supplier Id";
            // 
            // productsSupplierBindingSource
            // 
            this.productsSupplierBindingSource.DataSource = typeof(ClassEntites.ProductsSupplier);
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "ProductId", true));
            this.productIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.productIdTextBox.Location = new System.Drawing.Point(615, 32);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(141, 24);
            this.productIdTextBox.TabIndex = 2;
            // 
            // productSupplierIdComboBox
            // 
            this.productSupplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "ProductSupplierId", true));
            this.productSupplierIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSupplierIdComboBox.FormattingEnabled = true;
            this.productSupplierIdComboBox.Location = new System.Drawing.Point(295, 32);
            this.productSupplierIdComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.productSupplierIdComboBox.Name = "productSupplierIdComboBox";
            this.productSupplierIdComboBox.Size = new System.Drawing.Size(141, 26);
            this.productSupplierIdComboBox.TabIndex = 4;
            this.productSupplierIdComboBox.SelectedIndexChanged += new System.EventHandler(this.productSupplierIdComboBox_SelectedIndexChanged);
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "SupplierId", true));
            this.supplierIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIdTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.supplierIdTextBox.Location = new System.Drawing.Point(615, 90);
            this.supplierIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.ReadOnly = true;
            this.supplierIdTextBox.Size = new System.Drawing.Size(141, 24);
            this.supplierIdTextBox.TabIndex = 6;
            // 
            // txtProdSuppId
            // 
            this.txtProdSuppId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "ProductId", true));
            this.txtProdSuppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSuppId.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtProdSuppId.Location = new System.Drawing.Point(295, 88);
            this.txtProdSuppId.Margin = new System.Windows.Forms.Padding(5);
            this.txtProdSuppId.Name = "txtProdSuppId";
            this.txtProdSuppId.Size = new System.Drawing.Size(141, 24);
            this.txtProdSuppId.TabIndex = 8;
            this.txtProdSuppId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdSuppId_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(295, 143);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProdId
            // 
            this.txtProdId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "ProductId", true));
            this.txtProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdId.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtProdId.Location = new System.Drawing.Point(295, 224);
            this.txtProdId.Margin = new System.Windows.Forms.Padding(5);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(141, 24);
            this.txtProdId.TabIndex = 11;
            this.txtProdId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdId_KeyPress);
            // 
            // btnSearchProdId
            // 
            this.btnSearchProdId.Location = new System.Drawing.Point(43, 279);
            this.btnSearchProdId.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchProdId.Name = "btnSearchProdId";
            this.btnSearchProdId.Size = new System.Drawing.Size(125, 35);
            this.btnSearchProdId.TabIndex = 12;
            this.btnSearchProdId.Text = "Search";
            this.btnSearchProdId.UseVisualStyleBackColor = true;
            this.btnSearchProdId.Click += new System.EventHandler(this.btnSearchProdId_Click);
            // 
            // productsSupplierDataGridViewSortByProdId
            // 
            this.productsSupplierDataGridViewSortByProdId.AutoGenerateColumns = false;
            this.productsSupplierDataGridViewSortByProdId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsSupplierDataGridViewSortByProdId.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.productsSupplierDataGridViewSortByProdId.DataSource = this.productsSupplierBindingSource;
            this.productsSupplierDataGridViewSortByProdId.Location = new System.Drawing.Point(43, 349);
            this.productsSupplierDataGridViewSortByProdId.Margin = new System.Windows.Forms.Padding(5);
            this.productsSupplierDataGridViewSortByProdId.Name = "productsSupplierDataGridViewSortByProdId";
            this.productsSupplierDataGridViewSortByProdId.Size = new System.Drawing.Size(577, 338);
            this.productsSupplierDataGridViewSortByProdId.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // txtSuppId
            // 
            this.txtSuppId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "ProductId", true));
            this.txtSuppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppId.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtSuppId.Location = new System.Drawing.Point(1007, 225);
            this.txtSuppId.Margin = new System.Windows.Forms.Padding(5);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(141, 24);
            this.txtSuppId.TabIndex = 14;
            this.txtSuppId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuppId_KeyPress);
            // 
            // btnSearchSuppId
            // 
            this.btnSearchSuppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSuppId.Location = new System.Drawing.Point(787, 279);
            this.btnSearchSuppId.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchSuppId.Name = "btnSearchSuppId";
            this.btnSearchSuppId.Size = new System.Drawing.Size(117, 35);
            this.btnSearchSuppId.TabIndex = 15;
            this.btnSearchSuppId.Text = "Search";
            this.btnSearchSuppId.UseVisualStyleBackColor = true;
            this.btnSearchSuppId.Click += new System.EventHandler(this.btnSearchSuppId_Click);
            // 
            // productsSupplierDataGridViewSortBySuppId
            // 
            this.productsSupplierDataGridViewSortBySuppId.AutoGenerateColumns = false;
            this.productsSupplierDataGridViewSortBySuppId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsSupplierDataGridViewSortBySuppId.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productsSupplierDataGridViewSortBySuppId.DataSource = this.productsSupplierBindingSource;
            this.productsSupplierDataGridViewSortBySuppId.Location = new System.Drawing.Point(787, 349);
            this.productsSupplierDataGridViewSortBySuppId.Margin = new System.Windows.Forms.Padding(5);
            this.productsSupplierDataGridViewSortBySuppId.Name = "productsSupplierDataGridViewSortBySuppId";
            this.productsSupplierDataGridViewSortBySuppId.Size = new System.Drawing.Size(580, 338);
            this.productsSupplierDataGridViewSortBySuppId.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn6.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductSupplierId";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProductSupplierId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // productIdTextBoxAdd
            // 
            this.productIdTextBoxAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "ProductId", true));
            this.productIdTextBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBoxAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.productIdTextBoxAdd.Location = new System.Drawing.Point(1198, 28);
            this.productIdTextBoxAdd.Margin = new System.Windows.Forms.Padding(5);
            this.productIdTextBoxAdd.Name = "productIdTextBoxAdd";
            this.productIdTextBoxAdd.Size = new System.Drawing.Size(164, 24);
            this.productIdTextBoxAdd.TabIndex = 18;
            this.productIdTextBoxAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productIdTextBoxAdd_KeyPress);
            // 
            // supplierIdTextBoxAdd
            // 
            this.supplierIdTextBoxAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsSupplierBindingSource, "SupplierId", true));
            this.supplierIdTextBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIdTextBoxAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.supplierIdTextBoxAdd.Location = new System.Drawing.Point(1198, 68);
            this.supplierIdTextBoxAdd.Margin = new System.Windows.Forms.Padding(5);
            this.supplierIdTextBoxAdd.Name = "supplierIdTextBoxAdd";
            this.supplierIdTextBoxAdd.Size = new System.Drawing.Size(164, 24);
            this.supplierIdTextBoxAdd.TabIndex = 20;
            this.supplierIdTextBoxAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplierIdTextBoxAdd_KeyPress);
            // 
            // btnAddProdSupp
            // 
            this.btnAddProdSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdSupp.Location = new System.Drawing.Point(1198, 143);
            this.btnAddProdSupp.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProdSupp.Name = "btnAddProdSupp";
            this.btnAddProdSupp.Size = new System.Drawing.Size(96, 35);
            this.btnAddProdSupp.TabIndex = 21;
            this.btnAddProdSupp.Text = "Add";
            this.btnAddProdSupp.UseVisualStyleBackColor = true;
            this.btnAddProdSupp.Click += new System.EventHandler(this.btnAddProdSupp_Click);
            // 
            // ProductsSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 737);
            this.Controls.Add(this.btnAddProdSupp);
            this.Controls.Add(productIdLabel1);
            this.Controls.Add(this.productIdTextBoxAdd);
            this.Controls.Add(supplierIdLabel1);
            this.Controls.Add(this.supplierIdTextBoxAdd);
            this.Controls.Add(this.productsSupplierDataGridViewSortBySuppId);
            this.Controls.Add(this.btnSearchSuppId);
            this.Controls.Add(this.txtSuppId);
            this.Controls.Add(label3);
            this.Controls.Add(this.productsSupplierDataGridViewSortByProdId);
            this.Controls.Add(this.btnSearchProdId);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtProdSuppId);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(productSupplierIdLabel);
            this.Controls.Add(this.productSupplierIdComboBox);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductsSupplierForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierDataGridViewSortByProdId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSupplierDataGridViewSortBySuppId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productsSupplierBindingSource;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.ComboBox productSupplierIdComboBox;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.TextBox txtProdSuppId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Button btnSearchProdId;
        private System.Windows.Forms.DataGridView productsSupplierDataGridViewSortByProdId;
        private System.Windows.Forms.TextBox txtSuppId;
        private System.Windows.Forms.Button btnSearchSuppId;
        private System.Windows.Forms.DataGridView productsSupplierDataGridViewSortBySuppId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox productIdTextBoxAdd;
        private System.Windows.Forms.TextBox supplierIdTextBoxAdd;
        private System.Windows.Forms.Button btnAddProdSupp;
    }
}

