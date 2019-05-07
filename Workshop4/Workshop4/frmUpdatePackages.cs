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
    /// Purpose: Update Packages and Product Suppliers
    /// </summary>
    public partial class frmUpdatePackages : Form {
        public bool ProdSuppInserted { get; set; }

        public ProductsSupplier SelectedProductsSupplier { get; set; }
        public Package SelectedPackage { get; set; }
        public PackagesProductsSuppliers SelectedPkgProdSupp { get; set; }

        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<PackagesProductsSuppliers> PkgProdSupps { get; set; }
        public List<Package> Packages { get; set; }

        private bool PkgUpdated { get; set; }
        private Package OldPackage { get; set; }
        private ProductsSupplier OldProductsSupplier { get; set; }
        private PackagesProductsSuppliers OldPkgProdSupp { get; set; }

        public frmUpdatePackages() {
            InitializeComponent();
        }

        private void frmUpdatePackages_Load(object sender, EventArgs e) {
            // Create a copy of the selected object;
            OldPackage = new Package {
                PackageId = SelectedPackage.PackageId,
                PkgAgencyCommission = SelectedPackage.PkgAgencyCommission,
                PkgBasePrice = SelectedPackage.PkgBasePrice,
                PkgDesc = SelectedPackage.PkgDesc,
                PkgEndDate = SelectedPackage.PkgEndDate,
                PkgName = SelectedPackage.PkgName,
                PkgStartDate = SelectedPackage.PkgStartDate
            };

            OldProductsSupplier = new ProductsSupplier {
                ProductSupplierId = SelectedProductsSupplier.ProductSupplierId,
                ProductId = SelectedProductsSupplier.ProductId,
                SupplierId = SelectedProductsSupplier.SupplierId
            };

            OldPkgProdSupp = new PackagesProductsSuppliers {
                PackageId = SelectedPkgProdSupp.PackageId,
                ProductSupplierId = SelectedPkgProdSupp.ProductSupplierId
            };

            // Populate combo boxes
            prodNameComboBox.DisplayMember = "ProdName";
            prodNameComboBox.ValueMember = "ProductId";
            prodNameComboBox.DataSource = Products.OrderBy(p => p.ProdName).ToList();

            supNameComboBox.DisplayMember = "SupName";
            supNameComboBox.ValueMember = "SupplierId";
            supNameComboBox.DataSource = Suppliers.OrderBy(s => s.SupName).ToList();

            pkgNameTextBox.Text = SelectedPackage.PkgName;
            pkgBasePriceTextBox.Text = SelectedPackage.PkgBasePrice.ToString();

            if (SelectedPackage.PkgDesc == null)
                pkgDescTextBox.Text = string.Empty;
            else
                pkgDescTextBox.Text = SelectedPackage.PkgDesc;

            DateTime startDate = SelectedPackage.PkgStartDate ?? DateTime.MinValue;
            if (startDate == DateTime.MinValue) {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgStartDateDateTimePicker.CustomFormat = " ";
                pkgStartDateDateTimePicker.Checked = false;
            } else {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgStartDateDateTimePicker.Value = startDate;
            }

            DateTime endDate = SelectedPackage.PkgEndDate ?? DateTime.MinValue;
            if (endDate == DateTime.MinValue) {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgEndDateDateTimePicker.CustomFormat = " ";
                pkgEndDateDateTimePicker.Checked = false;
            } else {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgEndDateDateTimePicker.Value = endDate;
            }

            pkgAgencyCommissionTextBox.Text = SelectedPackage.PkgAgencyCommission.ToString();

            prodNameComboBox.SelectedValue = SelectedProductsSupplier.ProductId;
            supNameComboBox.SelectedValue = SelectedProductsSupplier.SupplierId;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            string pkgName;
            decimal basePrice;
            int productId;
            int supplierId;

            if (Validator.IsPresent(pkgNameTextBox)) { 
                pkgName = pkgNameTextBox.Text;

                // If Package Name already exists, get package object from database
                bool ValidPrice = true;
                bool DateValid = true;
                if (Validator.IsPresent(pkgBasePriceTextBox)) {
                    basePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);
                    SelectedPackage.PkgBasePrice = basePrice;

                    SelectedPackage.PkgName = pkgName;

                    if (string.IsNullOrWhiteSpace(pkgAgencyCommissionTextBox.Text)) {
                        SelectedPackage.PkgAgencyCommission = null;
                    } else {
                        SelectedPackage.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);
                    }

                    if (string.IsNullOrWhiteSpace(pkgDescTextBox.Text)) {
                        SelectedPackage.PkgDesc = null;
                    } else {
                        SelectedPackage.PkgDesc = pkgDescTextBox.Text;
                    }

                    if (pkgStartDateDateTimePicker.Checked == false &&
                        pkgEndDateDateTimePicker.Checked == false) {
                        SelectedPackage.PkgStartDate = null;
                        SelectedPackage.PkgEndDate = null;
                    } else if (pkgStartDateDateTimePicker.Checked == true &&
                        pkgEndDateDateTimePicker.Checked == false) {
                        // Package End Date has not been provided yet
                        SelectedPackage.PkgStartDate = pkgStartDateDateTimePicker.Value.Date;
                        SelectedPackage.PkgEndDate = null;
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
                            SelectedPackage.PkgStartDate = pkgStartDateDateTimePicker.Value.Date;
                            SelectedPackage.PkgEndDate = pkgEndDateDateTimePicker.Value.Date;
                        }
                    }
                    if (DateValid) {
                        // Update package in database
                        try {
                            if (!PackageDB.UpdatePackage(OldPackage, SelectedPackage)) {
                                MessageBox.Show("Another user has updated or " +
                                    "deleted that Package.", "Database Error");
                                DialogResult = DialogResult.Retry;
                                PkgUpdated = false;
                            } else {
                                PkgUpdated = true;
                            }
                        } catch (Exception ex) {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                } else {
                    ValidPrice = false;
                    DialogResult = DialogResult.None;
                }

                if (ValidPrice && DateValid && PkgUpdated) {
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

                        SelectedProductsSupplier = prodSupps;
                        ProdSuppInserted = true;
                    } else {
                        SelectedProductsSupplier =
                            ProductsSupplierDB.GetProductsSupplierByProductIdAndSupplierId(productId, supplierId);
                        ProdSuppInserted = false;
                    }

                    // Update Packages_Products_Supplier table                     
                    try {
                        // If there already exists a same packageId and ProductSupplierId combination
                        var pkgProdSuppTable = PkgProdSupps.SingleOrDefault(p => p.PackageId == SelectedPackage.PackageId
                            && p.ProductSupplierId == SelectedProductsSupplier.ProductSupplierId);

                        if (pkgProdSuppTable != null) {
                            MessageBox.Show("Package:  " + SelectedPackage.PkgName + " with \n" +
                                "Product Name:  " + prodNameComboBox.Text + "\nSupplier Name:  " +
                                supNameComboBox.Text + " \nalready exists", "Record Exists");
                            DialogResult = DialogResult.None;
                        } else {
                            // Verify against database
                            PackagesProductsSuppliers pkgPS = PackagesProductsSuppliersDB.GetPackagesProductsSuppliersByPkgIdAndProductSupplierId(SelectedPackage.PackageId,SelectedProductsSupplier.ProductSupplierId);
                            if (pkgPS == null) {
                                SelectedPkgProdSupp.ProductSupplierId = SelectedProductsSupplier.ProductSupplierId;
                                if (!PackagesProductsSuppliersDB.UpdatePackagesProductsSuppliers(OldPkgProdSupp, SelectedPkgProdSupp)) {
                                    MessageBox.Show("Another user has updated or " +
                                        "deleted that Package.", "Database Error");
                                    DialogResult = DialogResult.Retry;
                                } else {
                                    DialogResult = DialogResult.OK;
                                }
                            } else {
                                MessageBox.Show("Package:  " + SelectedPackage.PkgName + " with \n" +
                                    "Product Name:  " + prodNameComboBox.Text + "\nSupplier Name:  " +
                                    supNameComboBox.Text + " \nalready exists", "Record Exists");
                                SelectedPkgProdSupp = pkgPS;
                                DialogResult = DialogResult.OK;
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                } else {
                    DialogResult = DialogResult.None;
                }
            } else {
                DialogResult = DialogResult.None;
            }
        }

        private void pkgStartDateDateTimePicker_ValueChanged(object sender, EventArgs e) {
            pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
        }

        private void pkgEndDateDateTimePicker_ValueChanged(object sender, EventArgs e) {
            pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
        }

        private void btnReset_Click(object sender, EventArgs e) {
            pkgNameTextBox.Text = OldPackage.PkgName;
            pkgBasePriceTextBox.Text = OldPackage.PkgBasePrice.ToString();

            if (OldPackage.PkgDesc == null)
                pkgDescTextBox.Text = string.Empty;
            else
                pkgDescTextBox.Text = OldPackage.PkgDesc;

            DateTime startDate = OldPackage.PkgStartDate ?? DateTime.MinValue;
            if (startDate == DateTime.MinValue) {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgStartDateDateTimePicker.CustomFormat = " ";
                pkgStartDateDateTimePicker.Checked = false;
            } else {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgStartDateDateTimePicker.Value = startDate;
            }

            DateTime endDate = OldPackage.PkgEndDate ?? DateTime.MinValue;
            if (endDate == DateTime.MinValue) {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgEndDateDateTimePicker.CustomFormat = " ";
                pkgEndDateDateTimePicker.Checked = false;
            } else {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgEndDateDateTimePicker.Value = endDate;
            }

            pkgAgencyCommissionTextBox.Text = OldPackage.PkgAgencyCommission.ToString();

            prodNameComboBox.SelectedValue = OldProductsSupplier.ProductId;
            supNameComboBox.SelectedValue = OldProductsSupplier.SupplierId;

        }

        private void pkgAgencyCommissionTextBox_KeyPress(object sender, KeyPressEventArgs e) {
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

        private void pkgBasePriceTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            pkgAgencyCommissionTextBox_KeyPress(sender, e);
        }
    }
}
