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
    public partial class frmAgtInfo : Form {
        // Access agent info from main
        public Agent agent { get; set; }
        public frmAgtInfo() {
            InitializeComponent();
        }

        private void frmAgtInfo_Load(object sender, EventArgs e) {
            agencyIdLabel1.Text = agent.AgencyId.ToString();
            if (agent.AgtFirstName == null) 
                agtFirstNameLabel1.Text = string.Empty;
            else
                agtFirstNameLabel1.Text = agent.AgtFirstName;

            if (agent.AgtMiddleInitial == null)
                agtMiddleInitialLabel1.Text = string.Empty;
            else
                agtMiddleInitialLabel1.Text = agent.AgtMiddleInitial.ToString();

            if (agent.AgtLastName == null)
                agtLastNameLabel1.Text = string.Empty;
            else
                agtLastNameLabel1.Text = agent.AgtLastName.ToString();

            if (agent.AgtEmail == null)
                agtEmailLabel1.Text = string.Empty;
            else
                agtEmailLabel1.Text = agent.AgtEmail.ToString();

            if (agent.AgtBusPhone == null)
                agtBusPhoneLabel1.Text = string.Empty;
            else
                agtBusPhoneLabel1.Text = agent.AgtBusPhone.ToString();

            if (agent.AgtPosition == null)
                agtPositionLabel1.Text = string.Empty;
            else
                agtPositionLabel1.Text = agent.AgtPosition.ToString();
        }
    }
}
