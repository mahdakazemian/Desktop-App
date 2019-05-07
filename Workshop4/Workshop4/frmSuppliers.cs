/********************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 207 Rapid OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a collection of event methods for the Supplier Management
* form and forms part of the CPRG 207 Threaded Project Workshop 4.
*
*********************************************************************************/
using System;
using ClassEntites;
using DBAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4 {
    public partial class frmSuppliers : Form {
        // Form-level variable
        public MainForm mainForm { get; set; }
        public Agent loggedInAgt { get; set; }

        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers nethod call
            //suppliers = SupplierDB.GetSuppliers();
            suppliers = (SupplierDB.GetSuppliers()).OrderBy(s => s.SupplierId).ToList();

            // bind suppliers list to combo box
            cmbSuppliers.DataSource = suppliers;

        }
        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers method call
            suppliers = (SupplierDB.GetSuppliers()).OrderBy(s => s.SupplierId).ToList(); ;

            supplier = suppliers[cmbSuppliers.SelectedIndex];

            txtSupplierId.Text   = (supplier.SupplierId).ToString();
            txtSupplierName.Text = supplier.SupName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (loggedInAgt == null) {
                mainForm.btnSignIn_Click(null, null);
            } else {
                // declare suppliers List variable and instantiate new List<Supplier> object
                List<Supplier> suppliers = new List<Supplier>();

                // assign suppliers to return of GetSuppliers method call
                suppliers = SupplierDB.GetSuppliers();

                // validate input
                if (Validator.IsPresent(txtSupplierName))
                {
                    if ((txtSupplierName.Text.Length > 255))
                    {
                        MessageBox.Show("The Supplier Name is too long (>255). Please adjust.");
                        return;
                    }
                    // text boxes validated
                    // now check that the entered Supplier Name does not already exist in the database
                    foreach (Supplier supp in suppliers)
                    {
                        if (txtSupplierName.Text != "" && supp.SupName == txtSupplierName.Text)
                        {
                            MessageBox.Show("The Supplier Name already exists in the database");
                            return;
                        }
                    }

                    // business logic here is to determine the largest SupplierId in the database
                    // and then assign this value + 1, to the new Supplier entry
                    // Find largest SupplierID
                    int maxId = SupplierDB.FindMaxSupplierId(suppliers);

                    // create Supplier object to be added with new Id
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = ++maxId;
                    supplier.SupName = txtSupplierName.Text;

                    // problem below because Add Supplier should not return Id
                    bool result = SupplierDB.AddSupplier(supplier);
                    // assign suppliers to return of GetSuppliers method call
                    List<Supplier> newList = SupplierDB.GetSuppliers();
                    suppliers = newList.OrderBy(s => s.SupplierId).ToList();

                    // find index of new object in the sorted list
                    int indSorted = SupplierDB.FindIndexofId(suppliers, supplier.SupplierId);

                    // int numSuppliers = suppliers.Count();
                    DisplaySuppliers(indSorted);
                }
            }
        }


        public void DisplaySuppliers(int sIndex)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of SORTED GetSuppliers method call
            suppliers = (SupplierDB.GetSuppliers()).OrderBy(s=>s.SupplierId).ToList();
            // bind suppliers list to combo box
            cmbSuppliers.DataSource = suppliers;

            txtSupplierId.Text = (suppliers[sIndex].SupplierId).ToString();
            txtSupplierName.Text = suppliers[sIndex].SupName;

            cmbSuppliers.SelectedIndex = sIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (loggedInAgt == null) {
                mainForm.btnSignIn_Click(null, null);
            } else {
                // create Supplier object to be deleted
                Supplier supplier = new Supplier();
                supplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                supplier.SupName = txtSupplierName.Text;

                if (SupplierDB.IsInProductsSuppliers(supplier))
                {
                    MessageBox.Show("This supplier is already being used in " +
                        " the Products_Suppliers table and you may not delete it.");
                    return;
                }


                bool result = SupplierDB.DeleteSupplier(supplier);

                DisplaySuppliers(cmbSuppliers.SelectedIndex - 1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (loggedInAgt == null) {
                mainForm.btnSignIn_Click(null, null);
            } else {
                Supplier supplier = new Supplier();

                // declare products List variable and instantiate new List<Supplier> object
                List<Supplier> suppliers = new List<Supplier>();
                suppliers = SupplierDB.GetSuppliers().OrderBy(s => s.SupplierId).ToList();
                supplier = suppliers[cmbSuppliers.SelectedIndex];

                // check if product to be updated already exists in Products_Suppliers
                // table and if so, the user may not update it.

                if (SupplierDB.IsInProductsSuppliers(supplier))
                {
                    MessageBox.Show("This supplier is already being used in " +
                        " the Products_Suppliers table and you may not update it.");
                    return;
                }

                Supplier newSupplier = new Supplier();
                newSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                newSupplier.SupName = txtSupplierName.Text;

                bool result = SupplierDB.UpdateSupplier(supplier, newSupplier);
                DisplaySuppliers(cmbSuppliers.SelectedIndex);
            }
        }
    }
}

