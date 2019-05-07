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
    * Purpose :PackageSecondForm:to open second form in order to add/modify/delete a package
    */
    public partial class PackageSecondForm : Form
    {
        public PackageSecondForm()
        {
            InitializeComponent();
        }

        public bool addPackage; // indicates whether it is Add or Modify
        public Package package; // current package


        //when form loads
        private void PackageSecondForm_Load(object sender, EventArgs e)
        {
            if (addPackage)
            {
                this.Text = "Add Package";

            }
            else
            {
                this.Text = "Modify Package";
                this.DisplayPackage();
            }
        }

        // Accept button to accept add or modify function
        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                if (addPackage)
                {
                    package = new Package();
                    this.PutPackageData(package);
                    try
                    {
                        package.PackageId = PackageDB.AddPackage(package);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else // modify
                {
                    Package newPackage = new Package();
                    newPackage.PackageId = package.PackageId;
                    this.PutPackageData(newPackage);
                    try
                    {
                        if (!PackageDB.UpdatePackage(package, newPackage))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that package.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else // successfully updated
                        {
                            package = newPackage;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }// end of validation


        }// end of accept button


        // DisplayPackage function to display the packageid information in each text boxes
        private void DisplayPackage()
        {
            txtName.Text = package.PkgName;
            //txtStartDate.Text = package.PkgStartDate.ToString("yyyy-MM-dd");
            //txtEndDate.Text = package.PkgEndDate.ToString("yyyy-MM-dd");
            txtDesc.Text = package.PkgDesc;
            txtPrice.Text = package.PkgBasePrice.ToString();
            txtCommission.Text = package.PkgAgencyCommission.ToString();
        }

        //validation function
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtStartDate) &&
                Validator.IsDateTime(txtStartDate) &&
                Validator.IsPresent(txtEndDate) &&
                Validator.IsDateTime(txtEndDate) &&
                Validator.IsLatter(txtEndDate, txtStartDate) &&
                Validator.IsPresent(txtDesc) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice) &&
                Validator.IsPositiveDecimal(txtPrice) &&
                Validator.IsPresent(txtCommission) &&
                Validator.IsDecimal(txtCommission) &&
                Validator.IsPositiveDecimal(txtCommission) &&
                Validator.IsNotGreater(txtCommission, txtPrice);

        }
        //PutPackageData function to show new package information
        private void PutPackageData(Package package)
        {
            package.PkgName = txtName.Text;
            package.PkgStartDate = Convert.ToDateTime(txtStartDate.Text);
            package.PkgEndDate = Convert.ToDateTime(txtEndDate.Text);
            package.PkgDesc = txtDesc.Text;
            package.PkgBasePrice =Convert.ToDecimal( txtPrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
        }

        //cancel button to cancel the add or the modify and close the second form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }//end of class
}//end of namespace
