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
    public partial class ProductsSupplierForm : Form {

        /********************************
         *  FOR TESTING PURPOSES ONLY   *
         ********************************/

        // Form-level variables
        List<ProductsSupplier> prodSuppList = ProductsSupplierDB.GetAllProductsSuppliers();
        ProductsSupplier selectedProdSuppObj;

        public ProductsSupplierForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Load combo box with a list of Product Supplier Ids
            LoadComboBox();
        }

        
        private void LoadComboBox() {
            var productSupplier = from prodSupp in prodSuppList
                                  orderby prodSupp.ProductSupplierId
                                  select prodSupp.ProductSupplierId;
            var prodSuppIdList = productSupplier.ToList();
            productSupplierIdComboBox.DataSource = prodSuppIdList;
        }

        private void productSupplierIdComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                // Get the current selected Product Supplier ID
                int selectedProdSuppId = (int) productSupplierIdComboBox.SelectedValue;

                // Get the Product Supplier Object from the list of the selected Product Supplier ID
                selectedProdSuppObj = (from prodSupp in prodSuppList
                                       where prodSupp.ProductSupplierId == selectedProdSuppId
                                       select prodSupp).Single();

                DisplayProdSupp(selectedProdSuppObj);
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
            }
        }

        // Display Product Supplier Information
        private void DisplayProdSupp(ProductsSupplier prodSuppObj) {
            if (prodSuppObj.ProductId == null) {
                productIdTextBox.Text = "";
            } else {
                productIdTextBox.Text = prodSuppObj.ProductId.ToString();
            }

            if (prodSuppObj.SupplierId == null) {
                supplierIdTextBox.Text = "";
            } else {
                supplierIdTextBox.Text = prodSuppObj.SupplierId.ToString();
            }
        }

        // Search for Product Supplier by ID
        private void btnSearch_Click(object sender, EventArgs e) {
            if (Int32.TryParse(txtProdSuppId.Text, out int myInt)) {
                int prodSuppId = Convert.ToInt32(txtProdSuppId.Text);
                int searchIndex = productSupplierIdComboBox.Items.IndexOf(prodSuppId);
                productSupplierIdComboBox.SelectedIndex = searchIndex;
            } else {
                MessageBox.Show("Please Enter a Product Supplier ID to search", "Invalid Input");
                txtProdSuppId.SelectAll();
                txtProdSuppId.Focus();
            }
        }

        // Only allow numeric
        private void txtProdSuppId_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        // Search in the Product Supplier table by Product Id
        private void btnSearchProdId_Click(object sender, EventArgs e) {
            if (Int32.TryParse(txtProdId.Text, out int myInt)) {
                int prodId = Convert.ToInt32(txtProdId.Text);
                //List<ProductsSupplier> prodSuppListSortByProdId = ProductsSupplierDB.GetProductsSupplierByProductId(prodId);
                //productsSupplierDataGridViewSortByProdId.DataSource = prodSuppListSortByProdId;
            } else {
                MessageBox.Show("Please Enter a Product Supplier ID to search", "Invalid Input");
                txtProdId.SelectAll();
                txtProdId.Focus();
            }
        }

        // Search in the Product Supplier table by Supplier Id
        private void btnSearchSuppId_Click(object sender, EventArgs e) {
            if (Int32.TryParse(txtSuppId.Text, out int myInt)) {
                int suppId = Convert.ToInt32(txtSuppId.Text);
                //List<ProductsSupplier> prodSuppListSortBySuppId = ProductsSupplierDB.GetProductsSupplierBySupplierId(suppId);
                //productsSupplierDataGridViewSortBySuppId.DataSource = prodSuppListSortBySuppId;
            } else {
                MessageBox.Show("Please Enter a Product Supplier ID to search", "Invalid Input");
                txtProdId.SelectAll();
                txtProdId.Focus();
            }

        }

        private void txtSuppId_KeyPress(object sender, KeyPressEventArgs e) {
            txtProdSuppId_KeyPress(sender, e);
        }

        private void txtProdId_KeyPress(object sender, KeyPressEventArgs e) {
            txtProdSuppId_KeyPress(sender, e);
        }

        // Adding a new Products Supplier
        private void btnAddProdSupp_Click(object sender, EventArgs e) {
            ProductsSupplier newProdSuppObj = new ProductsSupplier();
            // if productIdTextBoxAdd is empty
            if (string.IsNullOrWhiteSpace(productIdTextBoxAdd.Text)) {
                newProdSuppObj.ProductId = null;
            } else {
                newProdSuppObj.ProductId = Convert.ToInt32(productIdTextBoxAdd.Text);
            }

            // if supplierIdTextBoxAdd is empty
            if (string.IsNullOrWhiteSpace(supplierIdTextBoxAdd.Text)) {
                newProdSuppObj.SupplierId = null;
            } else {
                newProdSuppObj.SupplierId = Convert.ToInt32(supplierIdTextBoxAdd.Text);
            }

            try {
                newProdSuppObj.ProductSupplierId = ProductsSupplierDB.AddProductsSupplier(newProdSuppObj);
                // Add to the Product Supplier List
                prodSuppList.Add(newProdSuppObj);
                // Reload combo box
                LoadComboBox();

                int searchIndex = productSupplierIdComboBox.Items.IndexOf(newProdSuppObj.ProductSupplierId);
                productSupplierIdComboBox.SelectedIndex = searchIndex;
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
            }
        }

        // Only allow numeric values
        private void productIdTextBoxAdd_KeyPress(object sender, KeyPressEventArgs e) {
            txtProdSuppId_KeyPress(sender, e);
        }

        // Only allow numeric values
        private void supplierIdTextBoxAdd_KeyPress(object sender, KeyPressEventArgs e) {
            txtProdSuppId_KeyPress(sender, e);
        }
    }
}
