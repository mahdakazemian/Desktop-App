namespace Workshop4 {
    partial class frmUpdatePackages {
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
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.supNameComboBox = new System.Windows.Forms.ComboBox();
            this.prodNameComboBox = new System.Windows.Forms.ComboBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            supNameLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.BackColor = System.Drawing.Color.Transparent;
            supNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.Location = new System.Drawing.Point(78, 144);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(117, 20);
            supNameLabel.TabIndex = 32;
            supNameLabel.Text = "Supplier Name:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.BackColor = System.Drawing.Color.Transparent;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(81, 102);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(114, 20);
            prodNameLabel.TabIndex = 30;
            prodNameLabel.Text = "Product Name:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.BackColor = System.Drawing.Color.Transparent;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(39, 319);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(156, 20);
            pkgAgencyCommissionLabel.TabIndex = 18;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.BackColor = System.Drawing.Color.Transparent;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(106, 275);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(89, 20);
            pkgBasePriceLabel.TabIndex = 20;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.BackColor = System.Drawing.Color.Transparent;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(102, 362);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(93, 20);
            pkgDescLabel.TabIndex = 22;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.BackColor = System.Drawing.Color.Transparent;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(114, 231);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(81, 20);
            pkgEndDateLabel.TabIndex = 24;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.BackColor = System.Drawing.Color.Transparent;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(140, 62);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(55, 20);
            pkgNameLabel.TabIndex = 26;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.BackColor = System.Drawing.Color.Transparent;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(108, 186);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(87, 20);
            pkgStartDateLabel.TabIndex = 28;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(123, 526);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 26);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(411, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 26);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // supNameComboBox
            // 
            this.supNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameComboBox.FormattingEnabled = true;
            this.supNameComboBox.Location = new System.Drawing.Point(246, 138);
            this.supNameComboBox.Name = "supNameComboBox";
            this.supNameComboBox.Size = new System.Drawing.Size(237, 26);
            this.supNameComboBox.TabIndex = 3;
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameComboBox.FormattingEnabled = true;
            this.prodNameComboBox.Location = new System.Drawing.Point(246, 96);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(237, 26);
            this.prodNameComboBox.TabIndex = 2;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(246, 315);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(237, 24);
            this.pkgAgencyCommissionTextBox.TabIndex = 7;
            this.pkgAgencyCommissionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pkgAgencyCommissionTextBox_KeyPress);
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(246, 271);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(237, 24);
            this.pkgBasePriceTextBox.TabIndex = 6;
            this.pkgBasePriceTextBox.Tag = "Package Base Price";
            this.pkgBasePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pkgBasePriceTextBox_KeyPress);
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgDescTextBox.Location = new System.Drawing.Point(246, 362);
            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(237, 118);
            this.pkgDescTextBox.TabIndex = 8;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.pkgEndDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(246, 225);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.ShowCheckBox = true;
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(237, 26);
            this.pkgEndDateDateTimePicker.TabIndex = 5;
            this.pkgEndDateDateTimePicker.ValueChanged += new System.EventHandler(this.pkgEndDateDateTimePicker_ValueChanged);
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgNameTextBox.Location = new System.Drawing.Point(246, 56);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(237, 24);
            this.pkgNameTextBox.TabIndex = 1;
            this.pkgNameTextBox.Tag = "Package Name";
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.pkgStartDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(246, 180);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.ShowCheckBox = true;
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(237, 26);
            this.pkgStartDateDateTimePicker.TabIndex = 4;
            this.pkgStartDateDateTimePicker.ValueChanged += new System.EventHandler(this.pkgStartDateDateTimePicker_ValueChanged);
            // 
            // frmUpdatePackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 613);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameComboBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameComboBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Name = "frmUpdatePackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Package";
            this.Load += new System.EventHandler(this.frmUpdatePackages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox supNameComboBox;
        private System.Windows.Forms.ComboBox prodNameComboBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
    }
}