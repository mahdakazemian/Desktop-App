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
    /// <summary>
    /// Author: Dao 
    /// Purpose: Add Packages and Product Suppliers
    /// </summary>
    public partial class frmAddPackages : Form {
        public bool PkgInserted { get; set; }
        public bool ProdSuppInserted { get; set; }

        public Package SelectedPkg { get; set; }
        public ProductsSupplier productsSupplier { get; set; }
        public Package Package { get; set; }
        public PackagesProductsSuppliers pkgProdSupp { get; set; }

        public List<Product> products { get; set; }
        public List<Supplier> suppliers { get; set; }
        public List<PackagesProductsSuppliers> pkgProdSupps { get; set; }
        public List<Package> packages { get; set; }

        public frmAddPackages() {
            InitializeComponent();
        }

        private void frmAddPackages_Load(object sender, EventArgs e) {
            // Load combo boxes
            prodNameComboBox.DisplayMember = "ProdName";
            prodNameComboBox.ValueMember = "ProductId";
            prodNameComboBox.DataSource = products.OrderBy(p => p.ProdName).ToList();

            supNameComboBox.DisplayMember = "SupName";
            supNameComboBox.ValueMember = "SupplierId";
            supNameComboBox.DataSource = suppliers.OrderBy(s => s.SupName).ToList();

            pkgNameTextBox.Text = SelectedPkg.PkgName;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string pkgName;
            decimal basePrice;
            int productId;
            int supplierId;

            if (Validator.IsPresent(pkgNameTextBox)) { 
                pkgName = pkgNameTextBox.Text;

                // If Package Name already exists, get package object from database
                bool ValidPrice = true;
                bool DateValid = true;
                var pkg = packages.SingleOrDefault(p => p.PkgName.ToLower() == pkgName.ToLower());
                
                if (pkg != null) {
                    Package = pkg;
                    PkgInserted = false;
                } else {
                    // Verify against database
                    Package pkgExist = PackageDB.GetPackageByName(pkgName);

                    if (pkgExist == null) {
                        Package newPkg = new Package();
                        if (Validator.IsPresent(pkgBasePriceTextBox)) {
                            basePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);
                            newPkg.PkgBasePrice = basePrice;

                            newPkg.PkgName = pkgName;

                            if (string.IsNullOrWhiteSpace(pkgAgencyCommissionTextBox.Text)) {
                                newPkg.PkgAgencyCommission = null;
                            } else {
                                newPkg.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);
                            }

                            if (string.IsNullOrWhiteSpace(pkgDescTextBox.Text)) {
                                newPkg.PkgDesc = null;
                            } else {
                                newPkg.PkgDesc = pkgDescTextBox.Text;
                            }

                            if (pkgStartDateDateTimePicker.Checked == false &&
                                pkgEndDateDateTimePicker.Checked == false) {
                                newPkg.PkgStartDate = null;
                                newPkg.PkgEndDate = null;
                            } else if (pkgStartDateDateTimePicker.Checked == true &&
                                pkgEndDateDateTimePicker.Checked == false) {
                                // Package End Date has not been provided yet
                                newPkg.PkgStartDate = pkgStartDateDateTimePicker.Value.Date;
                                newPkg.PkgEndDate = null;
                            } else if (pkgStartDateDateTimePicker.Checked == false &&
                                pkgEndDateDateTimePicker.Checked == true) {
                                MessageBox.Show("Must Provide a Valid Start Date");
                                DateValid = false;
                                DialogResult = DialogResult.None;
                            } else {
                                if (DateTime.Compare(pkgStartDateDateTimePicker.Value, pkgEndDateDateTimePicker.Value) >= 0) {
                                    MessageBox.Show("Start Date must be earlier than End Date");
                                    DateValid = false;
                                    DialogResult = DialogResult.None;
                                } else {
                                    newPkg.PkgStartDate = pkgStartDateDateTimePicker.Value.Date;
                                    newPkg.PkgEndDate = pkgEndDateDateTimePicker.Value.Date;
                                }
                            }
                            if (DateValid) {
                                // Add package to database
                                int pkgId = PackageDB.AddPackage(newPkg);
                                newPkg.PackageId = pkgId;
                                Package = newPkg;
                                PkgInserted = true;
                            }
                        } else {
                            ValidPrice = false;
                            DialogResult = DialogResult.None;
                        }
                    } else { // Package with pkgName exists in database
                        Package = pkgExist;
                        PkgInserted = true;
                    }
                }        
                if (ValidPrice && DateValid) {
                    productId = (int)prodNameComboBox.SelectedValue;
                    supplierId = (int)supNameComboBox.SelectedValue;

                    // Check if the combination of productId and supplierId already exists in database
                    if (ProductsSupplierDB.GetProductsSupplierByProductIdAndSupplierId(productId, supplierId) == null) {
                        // if doesn't exist in database, insert a new record
                        ProductsSupplier prodSupps = new ProductsSupplier {
                            ProductId = productId,
                            SupplierId = supplierId
                        };

                        // Insert into database
                        int prodSuppId = ProductsSupplierDB.AddProductsSupplier(prodSupps);
                        prodSupps.ProductSupplierId = prodSuppId;

                        productsSupplier = prodSupps;
                        ProdSuppInserted = true;
                    } else {
                        productsSupplier =
                            ProductsSupplierDB.GetProductsSupplierByProductIdAndSupplierId(productId, supplierId);
                        ProdSuppInserted = false;
                    }

                    // If there already exists a same packageId and ProductSupplierId combination
                    var pkgProdSuppTable = pkgProdSupps.SingleOrDefault(p => p.PackageId == Package.PackageId
                        && p.ProductSupplierId == productsSupplier.ProductSupplierId);

                    if (pkgProdSuppTable != null) {
                        MessageBox.Show("Package:  " + Package.PkgName + " with \n" +
                            "Product Name:  " + prodNameComboBox.Text + "\nSupplier Name:  " +
                            supNameComboBox.Text + " \nalready exists", "Record Exists");
                        DialogResult = DialogResult.None;
                    } else {
                        // Verify against database
                        PackagesProductsSuppliers pkgPS = PackagesProductsSuppliersDB.GetPackagesProductsSuppliersByPkgIdAndProductSupplierId(Package.PackageId,productsSupplier.ProductSupplierId);
                        if (pkgPS == null) {
                            PackagesProductsSuppliers pps = new PackagesProductsSuppliers();
                            pps.PackageId = Package.PackageId;
                            pps.ProductSupplierId = productsSupplier.ProductSupplierId;
                            // Insert into database
                            PackagesProductsSuppliersDB.AddPackagesProductsSuppliers(pps);
                            pkgProdSupp = pps;
                            DialogResult = DialogResult.OK;
                        } else {
                            MessageBox.Show("Package:  " + Package.PkgName + " with \n" +
                                "Product Name:  " + prodNameComboBox.Text + "\nSupplier Name:  " +
                                supNameComboBox.Text + " \nalready exists", "Record Exists");
                            pkgProdSupp = pkgPS;
                            DialogResult = DialogResult.OK;
                        }
                    }
                } else {
                    DialogResult = DialogResult.None;
                }
            } else {
                DialogResult = DialogResult.None;
            }
        }

        // Only allow numerics and one decimal
        private void pkgBasePriceTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            // e.KeyChar is the character pressed
            // e.Handled - boolean flag that says "I am done"
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.') {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void pkgAgencyCommissionTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            pkgBasePriceTextBox_KeyPress(sender, e);
        }

        private void pkgNameTextBox_Validating(object sender, CancelEventArgs e) {
            TextBox tb = sender as TextBox;

            // If Package Name already exists, get package object from database
            var pkg = packages.SingleOrDefault(p => p.PkgName.ToLower() == tb.Text.ToLower());

            if (pkg != null) {
                pkgBasePriceTextBox.ReadOnly = true;
                pkgDescTextBox.ReadOnly = true;
                pkgStartDateDateTimePicker.Enabled = false;
                pkgEndDateDateTimePicker.Enabled = false;
                pkgAgencyCommissionTextBox.ReadOnly = true;
            } else {
                // Verify against database
                Package pkgExist = PackageDB.GetPackageByName(tb.Text);
                if (pkgExist == null) {
                    pkgBasePriceTextBox.ReadOnly = false;
                    pkgDescTextBox.ReadOnly = false;
                    pkgStartDateDateTimePicker.Enabled = true;
                    pkgEndDateDateTimePicker.Enabled = true;
                    pkgAgencyCommissionTextBox.ReadOnly = false;
                } else {
                    pkgBasePriceTextBox.ReadOnly = true;
                    pkgDescTextBox.ReadOnly = true;
                    pkgStartDateDateTimePicker.Enabled = false;
                    pkgEndDateDateTimePicker.Enabled = false;
                    pkgAgencyCommissionTextBox.ReadOnly = true;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            pkgNameTextBox.Text = string.Empty;
            prodNameComboBox.SelectedIndex = 0;
            supNameComboBox.SelectedIndex = 0;
            pkgBasePriceTextBox.Text = string.Empty;
            pkgAgencyCommissionTextBox.Text = string.Empty;
            pkgDescTextBox.Text = string.Empty;
        }
    }
}
