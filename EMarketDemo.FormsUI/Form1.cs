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
            dgwProducts.DataSource = _productService.GetAll();
        }
        
    }
}
