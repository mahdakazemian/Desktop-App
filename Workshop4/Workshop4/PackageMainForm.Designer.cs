namespace Workshop4
{
    partial class PackageMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageMainForm));
            this.lblPackageId = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.lblPkgCommission = new System.Windows.Forms.Label();
            this.txtPkgId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.btnGetPkgId = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPackageId
            // 
            this.lblPackageId.AutoSize = true;
            this.lblPackageId.BackColor = System.Drawing.Color.Transparent;
            this.lblPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageId.ForeColor = System.Drawing.Color.Teal;
            this.lblPackageId.Location = new System.Drawing.Point(16, 15);
            this.lblPackageId.Name = "lblPackageId";
            this.lblPackageId.Size = new System.Drawing.Size(104, 20);
            this.lblPackageId.TabIndex = 0;
            this.lblPackageId.Text = "Package Id ";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgName.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgName.Location = new System.Drawing.Point(8, 65);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(134, 20);
            this.lblPkgName.TabIndex = 1;
            this.lblPkgName.Text = "Package Name ";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgStartDate.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgStartDate.Location = new System.Drawing.Point(8, 114);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(103, 20);
            this.lblPkgStartDate.TabIndex = 2;
            this.lblPkgStartDate.Text = " Start Date ";
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgEndDate.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgEndDate.Location = new System.Drawing.Point(8, 167);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(95, 20);
            this.lblPkgEndDate.TabIndex = 3;
            this.lblPkgEndDate.Text = " End Date ";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDesc.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgDesc.Location = new System.Drawing.Point(8, 225);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(110, 20);
            this.lblPkgDesc.TabIndex = 4;
            this.lblPkgDesc.Text = " Description ";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgBasePrice.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(16, 276);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(100, 20);
            this.lblPkgBasePrice.TabIndex = 5;
            this.lblPkgBasePrice.Text = "Base Price ";
            // 
            // lblPkgCommission
            // 
            this.lblPkgCommission.AutoSize = true;
            this.lblPkgCommission.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgCommission.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgCommission.Location = new System.Drawing.Point(16, 328);
            this.lblPkgCommission.Name = "lblPkgCommission";
            this.lblPkgCommission.Size = new System.Drawing.Size(110, 20);
            this.lblPkgCommission.TabIndex = 6;
            this.lblPkgCommission.Text = "Commission ";
            // 
            // txtPkgId
            // 
            this.txtPkgId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPkgId.Location = new System.Drawing.Point(152, 13);
            this.txtPkgId.Name = "txtPkgId";
            this.txtPkgId.Size = new System.Drawing.Size(227, 26);
            this.txtPkgId.TabIndex = 7;
            this.txtPkgId.Tag = "Package Id";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtName.Location = new System.Drawing.Point(152, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtStartDate.Location = new System.Drawing.Point(152, 114);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(227, 26);
            this.txtStartDate.TabIndex = 9;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtEndDate.Location = new System.Drawing.Point(152, 167);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(227, 26);
            this.txtEndDate.TabIndex = 10;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDesc.Location = new System.Drawing.Point(152, 225);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(447, 26);
            this.txtDesc.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPrice.Location = new System.Drawing.Point(152, 276);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 26);
            this.txtPrice.TabIndex = 12;
            // 
            // txtCommission
            // 
            this.txtCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCommission.Location = new System.Drawing.Point(152, 328);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(227, 26);
            this.txtCommission.TabIndex = 13;
            // 
            // btnGetPkgId
            // 
            this.btnGetPkgId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPkgId.ForeColor = System.Drawing.Color.Teal;
            this.btnGetPkgId.Location = new System.Drawing.Point(416, 10);
            this.btnGetPkgId.Name = "btnGetPkgId";
            this.btnGetPkgId.Size = new System.Drawing.Size(131, 39);
            this.btnGetPkgId.TabIndex = 14;
            this.btnGetPkgId.Text = "Get Package ";
            this.btnGetPkgId.UseVisualStyleBackColor = true;
            this.btnGetPkgId.Click += new System.EventHandler(this.btnGetPkgId_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(43, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.Teal;
            this.btnModify.Location = new System.Drawing.Point(167, 398);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 38);
            this.btnModify.TabIndex = 16;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(314, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(472, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // PackageMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 474);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetPkgId);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPkgId);
            this.Controls.Add(this.lblPkgCommission);
            this.Controls.Add(this.lblPkgBasePrice);
            this.Controls.Add(this.lblPkgDesc);
            this.Controls.Add(this.lblPkgEndDate);
            this.Controls.Add(this.lblPkgStartDate);
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.lblPackageId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PackageMainForm";
            this.Text = "PackageMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackageId;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.Label lblPkgCommission;
        private System.Windows.Forms.TextBox txtPkgId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Button btnGetPkgId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}