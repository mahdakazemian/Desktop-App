namespace Workshop4 {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblAgtName = new System.Windows.Forms.Label();
            this.pnlAgtBar = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSuppBar = new System.Windows.Forms.Panel();
            this.pnlProdBar = new System.Windows.Forms.Panel();
            this.pnlPackBar = new System.Windows.Forms.Panel();
            this.pnlHomeBar = new System.Windows.Forms.Panel();
            this.agentButton = new Workshop4.AgentButton();
            this.supplierButton = new Workshop4.SupplierButton();
            this.productButton = new Workshop4.ProductButton();
            this.packageButton = new Workshop4.PackageButton();
            this.homeButton = new Workshop4.HomeButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.agentButton);
            this.pnlMenu.Controls.Add(this.supplierButton);
            this.pnlMenu.Controls.Add(this.productButton);
            this.pnlMenu.Controls.Add(this.packageButton);
            this.pnlMenu.Controls.Add(this.homeButton);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.lblAgtName);
            this.pnlMenu.Controls.Add(this.pnlAgtBar);
            this.pnlMenu.Controls.Add(this.btnSignIn);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.pnlSuppBar);
            this.pnlMenu.Controls.Add(this.pnlProdBar);
            this.pnlMenu.Controls.Add(this.pnlPackBar);
            this.pnlMenu.Controls.Add(this.pnlHomeBar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 661);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Teal;
            this.btnLogOut.Location = new System.Drawing.Point(163, 594);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 32);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblAgtName
            // 
            this.lblAgtName.AutoSize = true;
            this.lblAgtName.Location = new System.Drawing.Point(54, 578);
            this.lblAgtName.Name = "lblAgtName";
            this.lblAgtName.Size = new System.Drawing.Size(35, 13);
            this.lblAgtName.TabIndex = 11;
            this.lblAgtName.Text = "label1";
            this.lblAgtName.Visible = false;
            // 
            // pnlAgtBar
            // 
            this.pnlAgtBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlAgtBar.Location = new System.Drawing.Point(0, 100);
            this.pnlAgtBar.Name = "pnlAgtBar";
            this.pnlAgtBar.Size = new System.Drawing.Size(10, 44);
            this.pnlAgtBar.TabIndex = 10;
            this.pnlAgtBar.Visible = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Teal;
            this.btnSignIn.Location = new System.Drawing.Point(45, 594);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(65, 32);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 594);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSuppBar
            // 
            this.pnlSuppBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlSuppBar.Location = new System.Drawing.Point(0, 408);
            this.pnlSuppBar.Name = "pnlSuppBar";
            this.pnlSuppBar.Size = new System.Drawing.Size(10, 44);
            this.pnlSuppBar.TabIndex = 8;
            this.pnlSuppBar.Visible = false;
            // 
            // pnlProdBar
            // 
            this.pnlProdBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlProdBar.Location = new System.Drawing.Point(0, 327);
            this.pnlProdBar.Name = "pnlProdBar";
            this.pnlProdBar.Size = new System.Drawing.Size(10, 44);
            this.pnlProdBar.TabIndex = 7;
            this.pnlProdBar.Visible = false;
            // 
            // pnlPackBar
            // 
            this.pnlPackBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlPackBar.Location = new System.Drawing.Point(0, 246);
            this.pnlPackBar.Name = "pnlPackBar";
            this.pnlPackBar.Size = new System.Drawing.Size(10, 44);
            this.pnlPackBar.TabIndex = 6;
            this.pnlPackBar.Visible = false;
            // 
            // pnlHomeBar
            // 
            this.pnlHomeBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHomeBar.Location = new System.Drawing.Point(0, 165);
            this.pnlHomeBar.Name = "pnlHomeBar";
            this.pnlHomeBar.Size = new System.Drawing.Size(10, 44);
            this.pnlHomeBar.TabIndex = 3;
            this.pnlHomeBar.Visible = false;
            // 
            // agentButton
            // 
            this.agentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agentButton.Location = new System.Drawing.Point(10, 100);
            this.agentButton.Margin = new System.Windows.Forms.Padding(5);
            this.agentButton.Name = "agentButton";
            this.agentButton.Size = new System.Drawing.Size(250, 44);
            this.agentButton.TabIndex = 17;
            this.agentButton.Visible = false;
            this.agentButton.Click += new System.EventHandler(this.agentButton_Click);
            this.agentButton.MouseEnter += new System.EventHandler(this.agentButton_MouseEnter);
            this.agentButton.MouseLeave += new System.EventHandler(this.agentButton_MouseLeave);
            // 
            // supplierButton
            // 
            this.supplierButton.Location = new System.Drawing.Point(10, 408);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(250, 44);
            this.supplierButton.TabIndex = 16;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            this.supplierButton.MouseEnter += new System.EventHandler(this.supplierButton_MouseEnter);
            this.supplierButton.MouseLeave += new System.EventHandler(this.supplierButton_MouseLeave);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(10, 327);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(250, 44);
            this.productButton.TabIndex = 15;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            this.productButton.MouseEnter += new System.EventHandler(this.productButton_MouseEnter);
            this.productButton.MouseLeave += new System.EventHandler(this.productButton_MouseLeave);
            // 
            // packageButton
            // 
            this.packageButton.Location = new System.Drawing.Point(10, 246);
            this.packageButton.Name = "packageButton";
            this.packageButton.Size = new System.Drawing.Size(250, 44);
            this.packageButton.TabIndex = 14;
            this.packageButton.Click += new System.EventHandler(this.packageButton_Click);
            this.packageButton.MouseEnter += new System.EventHandler(this.packageButton_MouseEnter);
            this.packageButton.MouseLeave += new System.EventHandler(this.packageButton_MouseLeave);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(10, 165);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(250, 44);
            this.homeButton.TabIndex = 13;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseEnter += new System.EventHandler(this.homeButton_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 64);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 661);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHomeBar;
        private System.Windows.Forms.Panel pnlPackBar;
        private System.Windows.Forms.Panel pnlSuppBar;
        private System.Windows.Forms.Panel pnlProdBar;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAgtBar;
        private System.Windows.Forms.Label lblAgtName;
        private System.Windows.Forms.Button btnLogOut;
        private HomeButton homeButton;
        private PackageButton packageButton;
        private ProductButton productButton;
        private SupplierButton supplierButton;
        private AgentButton agentButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}