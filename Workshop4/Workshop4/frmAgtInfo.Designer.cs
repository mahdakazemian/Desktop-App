namespace Workshop4 {
    partial class frmAgtInfo {
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
            System.Windows.Forms.Label agencyIdLabel;
            System.Windows.Forms.Label agtBusPhoneLabel;
            System.Windows.Forms.Label agtEmailLabel;
            System.Windows.Forms.Label agtFirstNameLabel;
            System.Windows.Forms.Label agtLastNameLabel;
            System.Windows.Forms.Label agtMiddleInitialLabel;
            System.Windows.Forms.Label agtPositionLabel;
            this.agencyIdLabel1 = new System.Windows.Forms.Label();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agtBusPhoneLabel1 = new System.Windows.Forms.Label();
            this.agtEmailLabel1 = new System.Windows.Forms.Label();
            this.agtFirstNameLabel1 = new System.Windows.Forms.Label();
            this.agtLastNameLabel1 = new System.Windows.Forms.Label();
            this.agtMiddleInitialLabel1 = new System.Windows.Forms.Label();
            this.agtPositionLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            agencyIdLabel = new System.Windows.Forms.Label();
            agtBusPhoneLabel = new System.Windows.Forms.Label();
            agtEmailLabel = new System.Windows.Forms.Label();
            agtFirstNameLabel = new System.Windows.Forms.Label();
            agtLastNameLabel = new System.Windows.Forms.Label();
            agtMiddleInitialLabel = new System.Windows.Forms.Label();
            agtPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // agencyIdLabel
            // 
            agencyIdLabel.AutoSize = true;
            agencyIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agencyIdLabel.Location = new System.Drawing.Point(278, 131);
            agencyIdLabel.Name = "agencyIdLabel";
            agencyIdLabel.Size = new System.Drawing.Size(84, 20);
            agencyIdLabel.TabIndex = 1;
            agencyIdLabel.Text = "Agency Id:";
            // 
            // agtBusPhoneLabel
            // 
            agtBusPhoneLabel.AutoSize = true;
            agtBusPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agtBusPhoneLabel.Location = new System.Drawing.Point(234, 376);
            agtBusPhoneLabel.Name = "agtBusPhoneLabel";
            agtBusPhoneLabel.Size = new System.Drawing.Size(128, 20);
            agtBusPhoneLabel.TabIndex = 5;
            agtBusPhoneLabel.Text = "Business Phone:";
            // 
            // agtEmailLabel
            // 
            agtEmailLabel.AutoSize = true;
            agtEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agtEmailLabel.Location = new System.Drawing.Point(310, 429);
            agtEmailLabel.Name = "agtEmailLabel";
            agtEmailLabel.Size = new System.Drawing.Size(52, 20);
            agtEmailLabel.TabIndex = 7;
            agtEmailLabel.Text = "Email:";
            // 
            // agtFirstNameLabel
            // 
            agtFirstNameLabel.AutoSize = true;
            agtFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agtFirstNameLabel.Location = new System.Drawing.Point(272, 178);
            agtFirstNameLabel.Name = "agtFirstNameLabel";
            agtFirstNameLabel.Size = new System.Drawing.Size(90, 20);
            agtFirstNameLabel.TabIndex = 9;
            agtFirstNameLabel.Text = "First Name:";
            // 
            // agtLastNameLabel
            // 
            agtLastNameLabel.AutoSize = true;
            agtLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agtLastNameLabel.Location = new System.Drawing.Point(272, 226);
            agtLastNameLabel.Name = "agtLastNameLabel";
            agtLastNameLabel.Size = new System.Drawing.Size(90, 20);
            agtLastNameLabel.TabIndex = 11;
            agtLastNameLabel.Text = "Last Name:";
            // 
            // agtMiddleInitialLabel
            // 
            agtMiddleInitialLabel.AutoSize = true;
            agtMiddleInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agtMiddleInitialLabel.Location = new System.Drawing.Point(262, 281);
            agtMiddleInitialLabel.Name = "agtMiddleInitialLabel";
            agtMiddleInitialLabel.Size = new System.Drawing.Size(100, 20);
            agtMiddleInitialLabel.TabIndex = 13;
            agtMiddleInitialLabel.Text = "Middle Initial:";
            // 
            // agtPositionLabel
            // 
            agtPositionLabel.AutoSize = true;
            agtPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agtPositionLabel.Location = new System.Drawing.Point(293, 328);
            agtPositionLabel.Name = "agtPositionLabel";
            agtPositionLabel.Size = new System.Drawing.Size(69, 20);
            agtPositionLabel.TabIndex = 15;
            agtPositionLabel.Text = "Position:";
            // 
            // agencyIdLabel1
            // 
            this.agencyIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgencyId", true));
            this.agencyIdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agencyIdLabel1.Location = new System.Drawing.Point(438, 131);
            this.agencyIdLabel1.Name = "agencyIdLabel1";
            this.agencyIdLabel1.Size = new System.Drawing.Size(208, 23);
            this.agencyIdLabel1.TabIndex = 2;
            this.agencyIdLabel1.Text = "label1";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(ClassEntites.Agent);
            // 
            // agtBusPhoneLabel1
            // 
            this.agtBusPhoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtBusPhone", true));
            this.agtBusPhoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agtBusPhoneLabel1.Location = new System.Drawing.Point(438, 376);
            this.agtBusPhoneLabel1.Name = "agtBusPhoneLabel1";
            this.agtBusPhoneLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtBusPhoneLabel1.TabIndex = 6;
            this.agtBusPhoneLabel1.Text = "label1";
            // 
            // agtEmailLabel1
            // 
            this.agtEmailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtEmail", true));
            this.agtEmailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agtEmailLabel1.Location = new System.Drawing.Point(438, 429);
            this.agtEmailLabel1.Name = "agtEmailLabel1";
            this.agtEmailLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtEmailLabel1.TabIndex = 8;
            this.agtEmailLabel1.Text = "label1";
            // 
            // agtFirstNameLabel1
            // 
            this.agtFirstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtFirstName", true));
            this.agtFirstNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agtFirstNameLabel1.Location = new System.Drawing.Point(438, 178);
            this.agtFirstNameLabel1.Name = "agtFirstNameLabel1";
            this.agtFirstNameLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtFirstNameLabel1.TabIndex = 10;
            this.agtFirstNameLabel1.Text = "label1";
            // 
            // agtLastNameLabel1
            // 
            this.agtLastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtLastName", true));
            this.agtLastNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agtLastNameLabel1.Location = new System.Drawing.Point(438, 226);
            this.agtLastNameLabel1.Name = "agtLastNameLabel1";
            this.agtLastNameLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtLastNameLabel1.TabIndex = 12;
            this.agtLastNameLabel1.Text = "label1";
            // 
            // agtMiddleInitialLabel1
            // 
            this.agtMiddleInitialLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtMiddleInitial", true));
            this.agtMiddleInitialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agtMiddleInitialLabel1.Location = new System.Drawing.Point(438, 281);
            this.agtMiddleInitialLabel1.Name = "agtMiddleInitialLabel1";
            this.agtMiddleInitialLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtMiddleInitialLabel1.TabIndex = 14;
            this.agtMiddleInitialLabel1.Text = "label1";
            // 
            // agtPositionLabel1
            // 
            this.agtPositionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtPosition", true));
            this.agtPositionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agtPositionLabel1.Location = new System.Drawing.Point(438, 325);
            this.agtPositionLabel1.Name = "agtPositionLabel1";
            this.agtPositionLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtPositionLabel1.TabIndex = 16;
            this.agtPositionLabel1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agent Profile";
            // 
            // frmAgtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(agencyIdLabel);
            this.Controls.Add(this.agencyIdLabel1);
            this.Controls.Add(agtBusPhoneLabel);
            this.Controls.Add(this.agtBusPhoneLabel1);
            this.Controls.Add(agtEmailLabel);
            this.Controls.Add(this.agtEmailLabel1);
            this.Controls.Add(agtFirstNameLabel);
            this.Controls.Add(this.agtFirstNameLabel1);
            this.Controls.Add(agtLastNameLabel);
            this.Controls.Add(this.agtLastNameLabel1);
            this.Controls.Add(agtMiddleInitialLabel);
            this.Controls.Add(this.agtMiddleInitialLabel1);
            this.Controls.Add(agtPositionLabel);
            this.Controls.Add(this.agtPositionLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgtInfo";
            this.Text = "frmAgtInfo";
            this.Load += new System.EventHandler(this.frmAgtInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.Label agencyIdLabel1;
        private System.Windows.Forms.Label agtBusPhoneLabel1;
        private System.Windows.Forms.Label agtEmailLabel1;
        private System.Windows.Forms.Label agtFirstNameLabel1;
        private System.Windows.Forms.Label agtLastNameLabel1;
        private System.Windows.Forms.Label agtMiddleInitialLabel1;
        private System.Windows.Forms.Label agtPositionLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}