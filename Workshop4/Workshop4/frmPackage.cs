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
    public partial class frmPackage : Form {
        // FORM-LEVEL VARIABLE
        // Get a list of all Package objects from database
        List<Package> packageList = PackageDB.GetAllPackages();
        // Get a list of all Product_Suppliers objects from database
        List<ProductsSupplier> prodSuppList = ProductsSupplierDB.GetAllProductsSuppliers();
        // Get a list of all Products objects from database
        List<Product> productsList = ProductDB.GetProducts();
        // Get a list of all Suppliers objects from database
        List<Supplier> suppliersList = SupplierDB.GetSuppliers();
        // Get a list of all Package_Product_Suppliers by package id
        List<PackagesProductsSuppliers> pkgProdSuppList = 
            PackagesProductsSuppliersDB.GetPackagesProductsSuppliers();

        // Store agent information
        public Agent loggedInAgt { get; set; }

        // Get mainform reference
        public MainForm mainForm { get; set; }

        public frmPackage() {
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e) {
            // Display a list of Package ids to the package Id combobox
            pkgNameComboBox.DisplayMember = "PkgName";
            pkgNameComboBox.ValueMember = "PackageId";
            pkgNameComboBox.DataSource = packageList;
        }

        private void pkgNameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (pkgNameComboBox.DataSource != null) {
                // Get Selected Package ID
                int pkgId = (int)pkgNameComboBox.SelectedValue;

                // Check if the first item in combo box is selected
                Package firstPkg = (Package)pkgNameComboBox.Items[0];
                int firstPkgId = firstPkg.PackageId;
                if (firstPkgId == pkgId) {
                    btnPrev.Enabled = false;
                } else {
                    btnPrev.Enabled = true;
                }

                // Check if the last item in combo box is selected
                int lastIndex = pkgNameComboBox.Items.Count - 1;
                Package lastPkg = (Package)pkgNameComboBox.Items[lastIndex];
                int lastPkgId = lastPkg.PackageId;
                if (lastPkgId == pkgId) {
                    btnNext.Enabled = false;
                } else {
                    btnNext.Enabled = true;
                }

                // Get Selected Package Object from a list of all packages
                Package pkgObj = packageList.SingleOrDefault(p => p.PackageId == pkgId);

                // Display Package information
                DisplayPkg(pkgObj);

                // Get associated product supplier
                var pkgProductSupplier = pkgProdSuppList.Where(pps => pps.PackageId == pkgId).ToList();

                // Join the product supplier table to products table and supplier table
                var productSupplierViewModels = (from pps in pkgProductSupplier
                                join ps in prodSuppList
                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                join p in productsList
                                on ps.ProductId equals p.ProductId
                                join s in suppliersList
                                on ps.SupplierId equals s.SupplierId
                                select new ProductSupplierViewModel {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProdName = p.ProdName,
                                    SuppName = s.SupName
                                }).ToList();

                // Bind List to data grid
                productSupplierViewModelDataGridView.DataSource = null;
                productSupplierViewModelDataGridView.DataSource = productSupplierViewModels;

                // Populate products combo box related to current package
                var productTable = from pps in pkgProductSupplier
                                   join ps in prodSuppList
                                   on pps.ProductSupplierId equals ps.ProductSupplierId
                                   join p in productsList
                                   on ps.ProductId equals p.ProductId
                                   select new Product {
                                       ProductId = (int)ps.ProductId,
                                       ProdName = p.ProdName
                                   };
                // remove duplicate
                var prodList = productTable.GroupBy(p => p.ProductId).Select(p => p.First()).ToList();
                prodList.Insert(0, new Product {
                    ProductId = -1,
                    ProdName = "--All--"
                });
                prodNameComboBox.DisplayMember = "ProdName";
                prodNameComboBox.ValueMember = "ProductId";
                prodNameComboBox.DataSource = prodList;
            }
        }

        private void DisplayPkg (Package pkgObj) {
            DateTime startDate = pkgObj.PkgStartDate ?? DateTime.MinValue;
            if (DateTime.Compare(startDate,DateTime.MinValue) == 0) {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgStartDateDateTimePicker.CustomFormat = " ";
            } else {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgStartDateDateTimePicker.Value = startDate;
            }

            DateTime endDate = pkgObj.PkgEndDate ?? DateTime.MinValue;
            if (DateTime.Compare(endDate,DateTime.MinValue) == 0) {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgEndDateDateTimePicker.CustomFormat = " ";
            } else {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgEndDateDateTimePicker.Value = endDate;
            }

            pkgBasePriceTextBox.Text = pkgObj.PkgBasePrice.ToString("c");

            decimal commission = pkgObj.PkgAgencyCommission ?? -1;
            if (commission == -1) {
                pkgAgencyCommissionTextBox.Text = pkgObj.PkgAgencyCommission.ToString();
            } else {
                pkgAgencyCommissionTextBox.Text = commission.ToString("c");
            }

            pkgDescTextBox.Text = pkgObj.PkgDesc;

        }

        private void btnAddPkg_Click(object sender, EventArgs e) {
            if (loggedInAgt == null) {
                mainForm.btnSignIn_Click(null,null);
            } else {
                // Get Selected Package Id
                int pkgId = (int)pkgNameComboBox.SelectedValue;

                // Get Selected Package Object
                var selectedPkg = packageList.SingleOrDefault(p => p.PackageId == pkgId);

                frmAddPackages frmAddPackages = new frmAddPackages();
                frmAddPackages.SelectedPkg = selectedPkg;
                frmAddPackages.products = productsList;
                frmAddPackages.suppliers = suppliersList;
                frmAddPackages.packages = packageList;
                frmAddPackages.pkgProdSupps = pkgProdSuppList;
                DialogResult result = frmAddPackages.ShowDialog();
                if (result == DialogResult.OK) {
                    if (frmAddPackages.PkgInserted == true) {
                        packageList.Add(frmAddPackages.Package);
                    }

                    if (frmAddPackages.ProdSuppInserted == true) {
                        prodSuppList.Add(frmAddPackages.productsSupplier);
                    }

                    pkgProdSuppList.Add(frmAddPackages.pkgProdSupp);

                    // Reload Combo box
                    refreshComboBox();

                    // Select the current package index
                    int index = packageList.IndexOf(frmAddPackages.Package);
                    pkgNameComboBox.SelectedIndex = index;
                }
            }
        }

        private void btnUpdatePkg_Click(object sender, EventArgs e) {
            if (loggedInAgt == null) {
                mainForm.btnSignIn_Click(null, null);
            } else {
                // Get Selected Package Id
                int pkgId = (int)pkgNameComboBox.SelectedValue;

                // Get Selected Package Object
                var selectedPkg = packageList.SingleOrDefault(p => p.PackageId == pkgId);

                // Get Data from datagridview
                int prodSuppId = (int)productSupplierViewModelDataGridView.CurrentRow.Cells[0].Value;
                var selectedProdSupp = prodSuppList.SingleOrDefault(ps => ps.ProductSupplierId == prodSuppId);

                var selectedPkgProdSupp = pkgProdSuppList.SingleOrDefault(pps => pps.ProductSupplierId == prodSuppId &&
                                                                        pps.PackageId == pkgId);

                frmUpdatePackages frmUpdatePackages = new frmUpdatePackages();
                // Assign reference to update form
                frmUpdatePackages.SelectedPackage = selectedPkg;
                frmUpdatePackages.SelectedProductsSupplier = selectedProdSupp;
                frmUpdatePackages.SelectedPkgProdSupp = selectedPkgProdSupp;

                // Assign list of all tables to update form
                frmUpdatePackages.Products = productsList;
                frmUpdatePackages.Suppliers = suppliersList;
                frmUpdatePackages.Packages = packageList;
                frmUpdatePackages.PkgProdSupps = pkgProdSuppList;

                DialogResult result = frmUpdatePackages.ShowDialog();
                if (result == DialogResult.OK) {
                    selectedPkg = frmUpdatePackages.SelectedPackage;
                    selectedPkgProdSupp = frmUpdatePackages.SelectedPkgProdSupp;
                    if (frmUpdatePackages.ProdSuppInserted) {
                        prodSuppList.Add(frmUpdatePackages.SelectedProductsSupplier);
                    }

                    // Refresh DataGridView
                    // Reload Combo box
                    refreshComboBox();

                    // Change combo box to the selected Package
                    pkgNameComboBox.SelectedValue = selectedPkg.PackageId;

                } else if (result == DialogResult.Retry) {
                    // Reload from database
                    reloadData();
                    refreshComboBox();
                }

            }
        }

        private void refreshComboBox() {
            pkgNameComboBox.DataSource = null;
            pkgNameComboBox.DisplayMember = "PkgName";
            pkgNameComboBox.ValueMember = "PackageId";
            pkgNameComboBox.DataSource = packageList;
            pkgNameComboBox.Refresh();
        }

        private void reloadData() {
            packageList = PackageDB.GetAllPackages();
            productsList = ProductDB.GetProducts();
            suppliersList = SupplierDB.GetSuppliers();
            prodSuppList = ProductsSupplierDB.GetAllProductsSuppliers();
            pkgProdSuppList = PackagesProductsSuppliersDB.GetPackagesProductsSuppliers();
        }

        private void btnDeletePkg_Click(object sender, EventArgs e) {
            if (loggedInAgt == null) {
                mainForm.btnSignIn_Click(null, null);
            } else { 
                // Get Selected Package Id
                int pkgId = (int)pkgNameComboBox.SelectedValue;

                // Get Selected Package Object
                var selectedPkg = packageList.SingleOrDefault(p => p.PackageId == pkgId);

                // Get Data from datagridview
                int prodSuppId = (int)productSupplierViewModelDataGridView.CurrentRow.Cells[0].Value;
                var selectedProdSupp = prodSuppList.SingleOrDefault(ps => ps.ProductSupplierId == prodSuppId);

                var selectedPkgProdSupp = pkgProdSuppList.SingleOrDefault(pps => pps.ProductSupplierId == prodSuppId &&
                                                                        pps.PackageId == pkgId);

                int pkgIdCount = pkgProdSuppList.Where(pps => pps.PackageId == pkgId).Count();
                if (pkgIdCount == 1) {
                    // If the packageId is the last one inside the Package_Products_Supplier table
                    // Then we delete that package in the Package Table
                    try {
                        deletePkgProdSupp(selectedPkgProdSupp);
                        if (!PackageDB.DeletePackage(selectedPkg)) {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that Package.", "Database Error");
                            // Refresh data
                            reloadData();
                            refreshComboBox();
                        } else {
                            int index = pkgNameComboBox.Items.IndexOf(selectedPkg);
                            packageList.Remove(selectedPkg);
                            pkgNameComboBox.SelectedIndex = index - 1;
                            refreshComboBox();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
                    }
                } else {
                    deletePkgProdSupp(selectedPkgProdSupp);
                    // If there are 2 or more packageIds inside Package_Products_Supplier, only delete
                    // from the package_products_supplier table, not the Package table
                }
            }
        }

        private void deletePkgProdSupp(PackagesProductsSuppliers packagesProductsSuppliers) {
            try {
                if (!PackagesProductsSuppliersDB.DeletePackagesProductsSuppliers(packagesProductsSuppliers)) {
                    MessageBox.Show("Another user has updated or " +
                        "deleted that Package.", "Database Error");
                    // Refresh data
                    reloadData();
                    refreshComboBox();
                } else {
                    pkgProdSuppList.Remove(packagesProductsSuppliers);
                    // Reload Combo box
                    refreshComboBox();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            // Get the last index so that next doesn't go out of bound
            int lastIndex = pkgNameComboBox.Items.Count - 1;
            int currentIndex = pkgNameComboBox.SelectedIndex;
            if (currentIndex + 1 == lastIndex) {
                btnNext.Enabled = false;
                currentIndex++;
                pkgNameComboBox.SelectedIndex = currentIndex;
            } else if (currentIndex < lastIndex) {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                currentIndex++;
                pkgNameComboBox.SelectedIndex = currentIndex;
            }

        }

        private void btnPrev_Click(object sender, EventArgs e) {
            int currentIndex = pkgNameComboBox.SelectedIndex;
            if (currentIndex - 1 == 0) {
                btnPrev.Enabled = false;
                currentIndex--;
                pkgNameComboBox.SelectedIndex = currentIndex;
            } else if (currentIndex > 0) {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                currentIndex--;
                pkgNameComboBox.SelectedIndex = currentIndex;
            }
        }

        private void prodNameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            productSupplierViewModelDataGridView.DataSource = null;
            // Get Selected Package ID
            int pkgId = (int)pkgNameComboBox.SelectedValue;

            // Get Selected product ID
            int prodId = (int)prodNameComboBox.SelectedValue;

            if (prodId == -1) {
                supNameComboBox.Enabled = false;
                supNameComboBox.Text = "--All--";
                // Get associated product supplier
                var pkgProductSupplier = pkgProdSuppList.Where(pps => pps.PackageId == pkgId).ToList();

                // Join the product supplier table to products table and supplier table
                var productSupplierViewModels = (from pps in pkgProductSupplier
                                join ps in prodSuppList
                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                join p in productsList
                                on ps.ProductId equals p.ProductId
                                join s in suppliersList
                                on ps.SupplierId equals s.SupplierId
                                select new ProductSupplierViewModel {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProdName = p.ProdName,
                                    SuppName = s.SupName
                                }).ToList();

                productSupplierViewModelDataGridView.DataSource = productSupplierViewModels;
            } else {
                // Get associated product supplier
                var pkgProductSupplier = pkgProdSuppList.Where(pps => pps.PackageId == pkgId).ToList();

                // Join the product supplier table to products table and supplier table
                var productSupplierViewModels = (from pps in pkgProductSupplier
                                join ps in prodSuppList
                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                join p in productsList
                                on ps.ProductId equals p.ProductId
                                join s in suppliersList
                                on ps.SupplierId equals s.SupplierId
                                where p.ProductId == prodId
                                select new ProductSupplierViewModel {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProdName = p.ProdName,
                                    SuppName = s.SupName
                                }).ToList();

                productSupplierViewModelDataGridView.DataSource = null;
                productSupplierViewModelDataGridView.DataSource = productSupplierViewModels;

                // Populate Suppliers combo box related to current package and product
                var supplierTable =  from pps in pkgProductSupplier
                                     join ps in prodSuppList
                                     on pps.ProductSupplierId equals ps.ProductSupplierId
                                     join p in productsList
                                     on ps.ProductId equals p.ProductId
                                     join s in suppliersList
                                     on ps.SupplierId equals s.SupplierId
                                     where p.ProductId == prodId
                                     select new Supplier {
                                         SupplierId = s.SupplierId,
                                         SupName = s.SupName
                                     };

                var suppList = supplierTable.GroupBy(s => s.SupplierId).Select(s => s.First()).ToList();

                suppList.Insert(0, new Supplier {
                    SupplierId = -1,
                    SupName = "--All--"
                });
                supNameComboBox.Enabled = true;
                supNameComboBox.DisplayMember = "SupName";
                supNameComboBox.ValueMember = "SupplierId";
                supNameComboBox.DataSource = suppList;
            }
        }

        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            // Get Selected Package ID
            int pkgId = (int)pkgNameComboBox.SelectedValue;

            // Get Selected product ID
            int prodId = (int)prodNameComboBox.SelectedValue;

            // Get Selected supplier ID
            int suppId = (int)supNameComboBox.SelectedValue;

            if (suppId == -1) {
                // Get associated product supplier
                var pkgProductSupplier = pkgProdSuppList.Where(pps => pps.PackageId == pkgId).ToList();

                // Join the product supplier table to products table and supplier table
                var productSupplierViewModels = (from pps in pkgProductSupplier
                                join ps in prodSuppList
                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                join p in productsList
                                on ps.ProductId equals p.ProductId
                                join s in suppliersList
                                on ps.SupplierId equals s.SupplierId
                                where p.ProductId == prodId
                                select new ProductSupplierViewModel {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProdName = p.ProdName,
                                    SuppName = s.SupName
                                }).ToList();

                productSupplierViewModelDataGridView.DataSource = null;
                productSupplierViewModelDataGridView.DataSource = productSupplierViewModels;

            } else {
                // Get associated product supplier
                var pkgProductSupplier = pkgProdSuppList.Where(pps => pps.PackageId == pkgId).ToList();

                // Join the product supplier table to products table and supplier table
                var productSupplierViewModels = (from pps in pkgProductSupplier
                                join ps in prodSuppList
                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                join p in productsList
                                on ps.ProductId equals p.ProductId
                                join s in suppliersList
                                on ps.SupplierId equals s.SupplierId
                                where p.ProductId == prodId && s.SupplierId == suppId
                                select new ProductSupplierViewModel {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProdName = p.ProdName,
                                    SuppName = s.SupName
                                }).ToList();

                productSupplierViewModelDataGridView.DataSource = null;
                productSupplierViewModelDataGridView.DataSource = productSupplierViewModels;

            }
        }
    }
}
