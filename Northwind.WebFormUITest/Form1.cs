using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entiites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormUITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            _ordersService = new OrderManager(new EfOrderDal());
        }
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private IOrdersService _ordersService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";

            cbxUpdatePCategory.DataSource = _categoryService.GetAll();
            cbxUpdatePCategory.DisplayMember = "CategoryName";
            cbxUpdatePCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = tbxAddProductName.Text,
                CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                QuantityPerUnit = tbxAddQuentityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxAddStock.Text)
            });
            LoadProducts();
            MessageBox.Show("Urun Kaydedildi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpdatePName.Text,
                CategoryId = Convert.ToInt32(cbxUpdatePCategory.SelectedValue),
                QuantityPerUnit = tbxUpdatePQuentityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdatePUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxUpdatePStock.Text)
            });
            LoadProducts();
            MessageBox.Show("Urun Guncellendi");

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdatePName.Text = row.Cells[1].Value.ToString();
            cbxUpdatePCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdatePUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdatePQuentityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUpdatePStock.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    LoadProducts();
                    MessageBox.Show("Urun Silindi");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _categoryService.GetAll();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _ordersService.GetAll();
        }

    }
}
