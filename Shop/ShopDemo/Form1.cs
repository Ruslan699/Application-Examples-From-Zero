using ShopDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        private void ProductList()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbx_Name.Text,

                Price = Convert.ToDecimal(tbx_Price.Text),

                StockAmount = Convert.ToInt32(tbx_StockAmount.Text)
            });

            ProductList();

            MessageBox.Show("Product Added");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Content Clicked");
        }

       
    }
}
