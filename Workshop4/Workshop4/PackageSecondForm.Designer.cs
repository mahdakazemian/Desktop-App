namespace Workshop4
{
    partial class PackageSecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageSecondForm));
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPkgCommission = new System.Windows.Forms.Label();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCommission
            // 
            this.txtCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCommission.Location = new System.Drawing.Point(211, 319);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(227, 24);
            this.txtCommission.TabIndex = 25;
            this.txtCommission.Tag = "Agency Commission";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPrice.Location = new System.Drawing.Point(211, 262);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 24);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.Tag = "Base Price";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDesc.Location = new System.Drawing.Point(211, 205);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(459, 24);
            this.txtDesc.TabIndex = 23;
            this.txtDesc.Tag = "Description";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtEndDate.Location = new System.Drawing.Point(211, 138);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(227, 24);
            this.txtEndDate.TabIndex = 22;
            this.txtEndDate.Tag = "End Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtStartDate.Location = new System.Drawing.Point(211, 79);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(227, 24);
            this.txtStartDate.TabIndex = 21;
            this.txtStartDate.Tag = "Start Date";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtName.Location = new System.Drawing.Point(211, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 24);
            this.txtName.TabIndex = 20;
            this.txtName.Tag = "Package Name";
            // 
            // lblPkgCommission
            // 
            this.lblPkgCommission.AutoSize = true;
            this.lblPkgCommission.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgCommission.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgCommission.Location = new System.Drawing.Point(10, 319);
            this.lblPkgCommission.Name = "lblPkgCommission";
            this.lblPkgCommission.Size = new System.Drawing.Size(169, 20);
            this.lblPkgCommission.TabIndex = 19;
            this.lblPkgCommission.Text = "AgencyCommission ";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgBasePrice.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(13, 262);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(100, 20);
            this.lblPkgBasePrice.TabIndex = 18;
            this.lblPkgBasePrice.Text = "Base Price ";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDesc.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgDesc.Location = new System.Drawing.Point(10, 205);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(110, 20);
            this.lblPkgDesc.TabIndex = 17;
            this.lblPkgDesc.Text = " Description ";
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgEndDate.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgEndDate.Location = new System.Drawing.Point(13, 138);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(95, 20);
            this.lblPkgEndDate.TabIndex = 16;
            this.lblPkgEndDate.Text = " End Date ";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgStartDate.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgStartDate.Location = new System.Drawing.Point(14, 79);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(103, 20);
            this.lblPkgStartDate.TabIndex = 15;
            this.lblPkgStartDate.Text = " Start Date ";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgName.ForeColor = System.Drawing.Color.Teal;
            this.lblPkgName.Location = new System.Drawing.Point(14, 19);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(134, 20);
            this.lblPkgName.TabIndex = 14;
            this.lblPkgName.Text = "Package Name ";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Teal;
            this.btnAccept.Location = new System.Drawing.Point(211, 415);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(97, 49);
            this.btnAccept.TabIndex = 26;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Teal;
            this.btnCancel.Location = new System.Drawing.Point(432, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 49);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PackageSecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 473);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPkgCommission);
            this.Controls.Add(this.lblPkgBasePrice);
            this.Controls.Add(this.lblPkgDesc);
            this.Controls.Add(this.lblPkgEndDate);
            this.Controls.Add(this.lblPkgStartDate);
            this.Controls.Add(this.lblPkgName);
            this.Name = "PackageSecondForm";
            this.Text = "PackageSecondForm";
            this.Load += new System.EventHandler(this.PackageSecondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPkgCommission;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}