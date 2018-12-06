using ShopWithEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWithEntityFramework
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
            LoadProducts();
        }

        //View List of products in DataGridView 
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            //Search From List, not good way,because If my Product name begins with uppercase L, 
            //but in txb_Search I wrote with lowerCase L it don't show,
            //if I wrote in this way I should write near Name(ToLower) and near key(ToLower)
            //var result = _productDal.GetAll().Where(x=>x.Name.ToLower().Contains(key.ToLower())).ToList();

            //Search From Database it's useful and right way

            var result = _productDal.GetByName(key);

            dgwProducts.DataSource = result;
        }


        //private void SearchProductsByPrice(int price)
        //{
        //    var result = _productDal.GetByPrice(price);

        //    dgwProducts.DataSource = result;
        //}

            private void btn_Add_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbx_Name.Text,

                Price = Convert.ToDecimal(tbx_Price.Text),

                StockAmount = Convert.ToInt32(tbx_StockAmount.Text)
            });

            LoadProducts();

            MessageBox.Show("Product Added");
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),

                Name = tbx_UpdatedName.Text,

                Price = Convert.ToDecimal(tbx_UpdatedPrice.Text),

                StockAmount = Convert.ToInt32(tbx_UpdatedStockAmount.Text)
            });

            LoadProducts();

            MessageBox.Show("Updated");
        }

        //view products in updated textboxes
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_UpdatedName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();

            tbx_UpdatedPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();

            tbx_UpdatedStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });

            LoadProducts();

            MessageBox.Show("Deleted");
        }

        private void tbx_Search_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbx_Search.Text);

            //SearchProductsByPrice(Convert.ToInt32(tbx_Search.Text));

        }

        
    }
}
