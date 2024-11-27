using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class ProductForm : BaseForm
    {
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;
        private readonly ApplicationDBContext _dbContext;
        public ProductForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            var categoryRepository = new CategoryRepository(_dbContext);
            var productRepository = new ProductRepository(_dbContext);
            _categoryService = new CategoryService(categoryRepository);
            _productService = new ProductService(productRepository);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void GetAllData()
        {
            //Kategorileri Getirelim:

            cmbCategories.ValueMember = "Id";
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.DataSource = _categoryService.GetAll();

            //Supplierları Getirelim:

            cmbSuppliers.DisplayMember = "CompanyName";
            cmbSuppliers.ValueMember = "Id";
            cmbSuppliers.DataSource = _dbContext.Suppliers.ToList();

            GetAllProducts();
        }

        private void GetAllProducts()
        {
            //Productları Getirelim:
            lstProductList.DisplayMember = "ProductName";
            lstProductList.ValueMember = "Id";
            lstProductList.DataSource = _productService.GetAll();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                Product p = new Product()
                {
                    ProductName = txtPrdName.Text,
                    UnitPrice = Convert.ToDouble(txtUPrice.Text),
                    UnitsInStock = Convert.ToInt32(txtQuantity.Text),
                    Discontinued = chkContinue.Checked,
                    IsActive = chkState.Checked,
                    Category = selectedCategory,
                    Supplier = selectedSupplier
                };

                if (_productService.IfEntityExists(a=>a.ProductName==p.ProductName))
                {
                    throw new Exception("Bu ürün daha önce sisteme girilmiştir.");
                }

                _productService.Create(p);
                MessageBox.Show("Kayıt Başarılı.");
                GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Supplier? selectedSupplier;
        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedIndex != -1)
            {
                selectedSupplier = (Supplier?)cmbSuppliers.SelectedItem;
            }
        }

        Category? selectedCategory;
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex != -1)
            {
                selectedCategory = (Category?)cmbCategories.SelectedItem;
            }
        }

        Product? selectedProduct;
        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedIndex != -1)
            {
                selectedProduct = (Product?)lstProductList.SelectedItem;
                txtPrdName.Text = selectedProduct.ProductName;
                txtQuantity.Text = selectedProduct.UnitsInStock.ToString();
                txtUPrice.Text = selectedProduct.UnitPrice.ToString();
                chkContinue.Checked = selectedProduct.Discontinued;
                chkState.Checked = selectedProduct.IsActive;
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct != null)
                {
                    DialogResult cvp = MessageBox.Show("Seçilen ürünü silmek istediğinizden emin misiniz?", "Ürüne ait tüm data silinecek.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (cvp == DialogResult.Yes)
                    {
                        _productService.Delete(selectedProduct.Id);
                        MessageBox.Show("Silme işlemi başarılı.");
                        GetAllProducts();
                    }
                    else
                    {
                        //Ürünün aktif özelliğini false yapalım.
                        _productService.ChangeProductStatus(selectedProduct.Id);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductForm_Click(object sender, EventArgs e)
        {
            lstProductList.ClearSelected();
        }

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct != null)
                {
                    selectedProduct.ProductName = txtPrdName.Text;
                    selectedProduct.UnitPrice = Convert.ToInt32(txtUPrice.Text);
                    selectedProduct.Discontinued = chkContinue.Checked;
                    selectedProduct.UnitsInStock = Convert.ToInt32(txtQuantity.Text);
                    selectedProduct.IsActive = chkState.Checked;
                    selectedProduct.Supplier = selectedSupplier;
                    selectedProduct.Category = selectedCategory;
                    _productService.Update(selectedProduct);
                    GetAllProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
