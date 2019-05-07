using ClassEntites;
using DBAccess;
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
    public partial class frmLogin : Form {
        // Get main agent login reference
        public Agent loggedInAgt { get; set; }
        public frmLogin() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e) {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            List<Agent> agents = AgentDB.GetAllAgents();

            // Find if user first name and last name is in database
            var agent = agents.SingleOrDefault(a => a.AgtFirstName.ToLower() == firstName.ToLower()
                                               && a.AgtLastName.ToLower() == lastName.ToLower());

            if (agent != null) { // if found a match
                loggedInAgt = new Agent();
                loggedInAgt.AgentId = agent.AgentId;
                loggedInAgt.AgtFirstName = agent.AgtFirstName;
                loggedInAgt.AgtMiddleInitial = agent.AgtMiddleInitial;
                loggedInAgt.AgtLastName = agent.AgtLastName;
                loggedInAgt.AgtEmail = agent.AgtEmail;
                loggedInAgt.AgtBusPhone = agent.AgtBusPhone;
                loggedInAgt.AgtPosition = agent.AgtPosition;
                loggedInAgt.AgencyId = agent.AgencyId;
                DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("Incorrect First Name or Last Name");
                DialogResult = DialogResult.None;
            }
        }

        private void txtFirstName_GotFocus(object sender, EventArgs e) {
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Text = "";
        }
        private void txtFirstName_LostFocus(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)) {
                txtFirstName.ForeColor = Color.Gray;
                txtFirstName.Text = "First Name";
            }

        }

        private void txtLastName_GotFocus(object sender, EventArgs e) {
            txtLastName.ForeColor = Color.Black;
            txtLastName.Text = "";
        }
        private void txtLastName_LostFocus(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) {
                txtLastName.ForeColor = Color.Gray;
                txtLastName.Text = "Last Name";
            }

        }

        private void frmLogin_Load(object sender, EventArgs e) {
            txtFirstName.ForeColor = Color.Gray;
            txtFirstName.Text = "First Name";

            txtLastName.ForeColor = Color.Gray;
            txtLastName.Text = "Last Name";

        }
    }
}
