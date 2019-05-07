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

namespace Workshop4
{
    /*
    * Term 2 Threaded Project 
    * Author : Mahda Kazemian
    * Date : March 19,2019
    * Course Name : Threaded Project for OOSD
    * Module : PROJ-207-OOSD
    * Purpose :PackageMainForm:Create Windows Form application that connects to
    *  the Travelexpert database and retrieves data from Packages table. 
    *  also it has different button to modify the package.
    */
    public partial class PackageMainForm : Form
    {
        public PackageMainForm()
        {
            InitializeComponent();
        }
        private Package  package; //current package




        //GetPackage button to get the packageid and search in database
        private void btnGetPkgId_Click_1(object sender, EventArgs e)
        {

            //validation for packageid
            if (Validator.IsPresent(txtPkgId) &&
                Validator.IsInt32(txtPkgId))
            {
                int packageId = Convert.ToInt32(txtPkgId.Text);//show the packageid in text box
                this.GetPackage(packageId);//call GetPackage function to display the packageid info


                if (package == null) //if packageid is not in the database 
                {
                    MessageBox.Show("No package found with this ID. " +
                         "Please try again.", "Package Not Found");
                    this.ClearControls();
                }
                else
                    this.DisplayPackage();//otherwise show the packageid information
            }


        }// end of GetPackage button

        // GetPackage function to display the packageid information
        private void GetPackage(int packageId)
        {
            try
            {
                package = PackageDB.GetPackage(packageId);
            }
            catch (Exception ex)//show an error if catch any problem
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // ClearControls function to clear the text boxes if they have already an 
        // packageid info and we want to try another packageid which is not in database.
        private void ClearControls()
        {
            txtPkgId.Text = "";
            txtName.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtCommission.Text = "";
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtPkgId.Select();
        }

        // DisplayPackage function to display the packageid information in each text boxes
        private void DisplayPackage()
        {
            txtName.Text = package.PkgName;
            //txtStartDate.Text = package.PkgStartDate.ToString("yyyy-MM-dd");
            //txtEndDate.Text = package.PkgEndDate.ToString("yyyy-MM-dd");
            txtDesc.Text = package.PkgDesc;
            txtPrice.Text = package.PkgBasePrice.ToString("c");
            //txtCommission.Text = package.PkgAgencyCommission.ToString("c");
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        
        
        //add button to add a new package and it opens the second form
        private void btnAdd_Click(object sender, EventArgs e)
        {

            PackageSecondForm addPackageForm = new PackageSecondForm();
            addPackageForm.addPackage = true;
            DialogResult result = addPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                package = addPackageForm.package;
                txtPkgId.Text = package.PackageId.ToString();
                this.DisplayPackage();
            }

        }
        // Modify Button to modify a package and it opens the second form
        private void btnModify_Click(object sender, EventArgs e)
        {

            PackageSecondForm modifyPackageForm = new PackageSecondForm();
            modifyPackageForm.addPackage = false;
            modifyPackageForm.package = package;
            DialogResult result = modifyPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                package = modifyPackageForm.package;
                this.DisplayPackage();
            }
            else if (result == DialogResult.Retry)
            {
                this.GetPackage(package.PackageId);
                if (package != null)
                    this.DisplayPackage();
                else
                    this.ClearControls();
            }

        }
        // delete button to delete a package
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + package.PkgName + "?",
               "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!PackageDB.DeletePackage(package)) // optimistic concurrency violation
                    {
                        MessageBox.Show("Another user has updated or deleted " +
                            "that package.", "Database Error");
                        this.GetPackage(package.PackageId);
                        if (package != null)
                            this.DisplayPackage();
                        else
                            this.ClearControls();
                    }
                    else // successful delete
                        this.ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // Exit buttun to close the main form
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxPkg_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }// end of class
}// end of namespace
