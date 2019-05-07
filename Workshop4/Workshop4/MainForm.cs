using ClassEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4 {
    public partial class MainForm : Form {

        // Form-level variables
        private static bool homeFormOpened = false;
        private static bool agtFormOpened = false;
        private static bool pkgFormOpened = false;
        private static bool prodsFormOpened = false;
        private static bool suppsFormOpened = false;

        // Instantiate child forms
        frmHome homeForm = new frmHome();
        frmAgtInfo agtForm = new frmAgtInfo();
        frmPackage pkgForm = new frmPackage();
        frmProducts prodsForm = new frmProducts();
        frmSuppliers suppsForm = new frmSuppliers();

        // Store logged in agent information
        public Agent loggedInAgt { get; set; }

        public MainForm() {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = true;
            pnlAgtBar.Visible = false;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.MintCream;
            agentButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.Black;

            // Reset control for all other forms
            agtFormOpened = false;
            pkgFormOpened = false;
            prodsFormOpened = false;
            suppsFormOpened = false;

            if (homeFormOpened == false) {
                // Hide all other forms
                agtForm.Hide();
                pkgForm.Hide();
                prodsForm.Hide();
                suppsForm.Hide();

                homeForm.MdiParent = this;
                homeForm.Dock = DockStyle.Fill;
                homeForm.Show();
                homeFormOpened = true;
            }
        }
        private void agentButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = false;
            pnlAgtBar.Visible = true;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = false;
            
            // Set the active font color
            homeButton.ForeColor = Color.Black;
            agentButton.ForeColor = Color.MintCream;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.Black;

            // Reset control for all other forms
            homeFormOpened = false;
            pkgFormOpened = false;
            prodsFormOpened = false;
            suppsFormOpened = false;

            if (agtFormOpened == false) {
                // Hide all other forms
                homeForm.Hide();
                pkgForm.Hide();
                prodsForm.Hide();
                suppsForm.Hide();

                agtForm = new frmAgtInfo();
                agtForm.agent = loggedInAgt;
                agtForm.MdiParent = this;
                agtForm.Dock = DockStyle.Fill;
                agtForm.Show();
                agtFormOpened = true;
            }
        }

        private void packageButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = false;
            pnlAgtBar.Visible = false;
            pnlPackBar.Visible = true;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.Black;
            agentButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.MintCream;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.Black;

            // Reset all other forms
            homeFormOpened = false;
            prodsFormOpened = false;
            suppsFormOpened = false;
            agtFormOpened = false;

            if (pkgFormOpened == false) {
                // Hide all other forms
                homeForm.Hide();
                agtForm.Hide();
                prodsForm.Hide();
                suppsForm.Hide();

                pkgForm.MdiParent = this;
                pkgForm.Dock = DockStyle.Fill;
                pkgForm.Show();
                pkgFormOpened = true;
            }
        }

        private void productButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = false;
            pnlAgtBar.Visible = false;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = true;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.Black;
            agentButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.MintCream;
            supplierButton.ForeColor = Color.Black;

            // Reset all other forms
            homeFormOpened = false;
            pkgFormOpened = false;
            suppsFormOpened = false;
            agtFormOpened = false;

            if (prodsFormOpened == false) {
                // Hide all other forms
                homeForm.Hide();
                agtForm.Hide();
                pkgForm.Hide();
                suppsForm.Hide();

                prodsForm.MdiParent = this;
                prodsForm.Dock = DockStyle.Fill;
                prodsForm.Show();
                prodsFormOpened = true;
            }
        }

        private void supplierButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = false;
            pnlAgtBar.Visible = false;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = true;

            // Set the active font color
            homeButton.ForeColor = Color.Black;
            agentButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.MintCream;


            // Reset all other forms
            homeFormOpened = false;
            pkgFormOpened = false;
            prodsFormOpened = false;
            agtFormOpened = false;

            if (suppsFormOpened == false) {
                // Hide all other forms
                homeForm.Hide();
                agtForm.Hide();
                pkgForm.Hide();
                prodsForm.Hide();

                suppsForm.MdiParent = this;
                suppsForm.Dock = DockStyle.Fill;
                suppsForm.Show();
                suppsFormOpened = true;
            }
        }

        private void homeButton_MouseEnter(object sender, EventArgs e) {
            homeButton.BackColor = Color.BurlyWood;
        }
        private void agentButton_MouseEnter(object sender, EventArgs e) {
            agentButton.BackColor = Color.BurlyWood;
        }
        private void packageButton_MouseEnter(object sender, EventArgs e) {
            packageButton.BackColor = Color.BurlyWood;
        }
        private void productButton_MouseEnter(object sender, EventArgs e) {
            productButton.BackColor = Color.BurlyWood;
        }
        private void supplierButton_MouseEnter(object sender, EventArgs e) {
            supplierButton.BackColor = Color.BurlyWood;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            homeButton.BackColor = Color.LightSkyBlue;
        }
        private void agentButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            agentButton.BackColor = Color.LightSkyBlue;
        }
        private void packageButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            packageButton.BackColor = Color.LightSkyBlue;
        }
        private void productButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            productButton.BackColor = Color.LightSkyBlue;
        }
        private void supplierButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            supplierButton.BackColor = Color.LightSkyBlue;
        }

        public void btnSignIn_Click(object sender, EventArgs e) {
            frmLogin loginForm = new frmLogin();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK) {

                // Show and adjust agent button
                agentButton.Visible = true;
                agentButton.Location = new Point(10, 165);
                pnlAgtBar.Location = new Point(0, 165);

                // Move home button up
                homeButton.Location = new Point(10, 84);
                pnlHomeBar.Location = new Point(0, 84);

                // Assign to global agent logged in variable
                loggedInAgt = loginForm.loggedInAgt;
                pkgForm.loggedInAgt = loggedInAgt;
                prodsForm.loggedInAgt = loggedInAgt;
                suppsForm.loggedInAgt = loggedInAgt;

                // Set welcome message for agent
                string agtName = $"{loggedInAgt.AgtFirstName} {loggedInAgt.AgtLastName}";
                lblAgtName.Visible = true;
                lblAgtName.Text = agtName;
                lblAgtName.ForeColor = Color.Crimson;
                lblAgtName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                lblAgtName.Location = new Point(45, 600);

                // Make log in button invisible once agent has logged in
                btnSignIn.Visible = false;

                // Make log out button visible
                btnLogOut.Visible = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            // Make sign in button visible
            btnSignIn.Visible = true;

            // Hide log out button
            btnLogOut.Visible = false;

            // Hide logged in agent name
            lblAgtName.Visible = false;

            // Hide agent button
            agentButton.Visible = false;

            // Move home button down
            homeButton.Location = new Point(10, 165);
            pnlHomeBar.Location = new Point(0, 165);

            // Reset Global loggedInAgt object
            loggedInAgt = null;
            pkgForm.loggedInAgt = null;
            prodsForm.loggedInAgt = null;
            suppsForm.loggedInAgt = null;

            // Redirect to home page 
            homeForm.Show();
            homeForm.MdiParent = this;
            // Set active bar
            pnlHomeBar.Visible = true;
            pnlAgtBar.Visible = false;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.DodgerBlue;
            agentButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.Black;

            // Reset all other forms
            homeFormOpened = true;
            pkgFormOpened = false;
            prodsFormOpened = false;
            suppsFormOpened = false;
            agtFormOpened = false;

            agtForm.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.SetBevel(false);

            // Pass reference to child forms
            pkgForm.mainForm = this;
            prodsForm.mainForm = this;
            suppsForm.mainForm = this;

            // Set active bar
            pnlHomeBar.Visible = true;
            pnlAgtBar.Visible = false;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.MintCream;
            agentButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.Black;

            homeForm.MdiParent = this;
            homeForm.Dock = DockStyle.Fill;
            homeForm.Show();
            homeFormOpened = true;
        }
    }
}
