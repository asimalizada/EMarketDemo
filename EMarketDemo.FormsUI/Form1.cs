using EMarketDemo.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMarketDemo.Business.Concrete;
using EMarketDemo.DataAccess.Concrete.EntityFramework;
using EMarketDemo.Entities.Concrete;

namespace EMarketDemo.FormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        public Form1()
        {
            _productService = new ProductManager(new EfProductDal());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = tbxNameAdd.Text,
                CategoryId = Convert.ToInt32(tbxCategoryIdAdd.Text),
                Price = Convert.ToDecimal(tbxPriceAdd.Text),
                UnitsInStock = Convert.ToInt32(tbxUnitsInStockAdd.Text)
            });
            LoadProducts();
            MessageBox.Show("Product added!", "Message :");
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e) // event
        {
            _productService.Update(new Product
            {
                Id = (int) dgwProducts.CurrentRow.Cells[0].Value,
                ProductName = tbxNameUpdate.Text,
                CategoryId = Convert.ToInt32(tbxCategoryIdUpdate.Text),
                Price = Convert.ToDecimal(tbxPriceUpdate.Text),
                UnitsInStock = Convert.ToInt32(tbxUnitsInStockUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Product updated!", "Message :");
            ClearTextBoxes();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwProducts.CurrentRow.Cells;
            tbxNameUpdate.Text = cells[1].Value.ToString();
            tbxCategoryIdUpdate.Text = cells[2].Value.ToString();
            tbxPriceUpdate.Text = cells[3].Value.ToString();
            tbxUnitsInStockUpdate.Text = cells[4].Value.ToString();
        }

        private void ClearTextBoxes()
        {
            tbxNameUpdate.Text = "";
            tbxCategoryIdUpdate.Text = "";
            tbxPriceUpdate.Text = "";
            tbxUnitsInStockUpdate.Text = "";

            tbxNameAdd.Text = "";
            tbxCategoryIdAdd.Text = "";
            tbxPriceAdd.Text = "";
            tbxUnitsInStockAdd.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                Id = (int) dgwProducts.CurrentRow.Cells[0].Value
            });
            LoadProducts();
            MessageBox.Show("Product deleted!", "Message :");
            ClearTextBoxes();
        }
    }
}
