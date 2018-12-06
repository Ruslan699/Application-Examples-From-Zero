using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL _productDAL = new ProductDAL();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        //View List of products in DataGridView 
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDAL.GetAll();
        }


        //add product
        private void btn_Add_Click(object sender, EventArgs e)
        {
            _productDAL.Add(new Product
            {
                Name = tbx_Name.Text,

                Price = Convert.ToDecimal(tbx_Price.Text),

                StockAmount = Convert.ToInt32(tbx_StockAmount.Text)

            });

            LoadProducts();

            MessageBox.Show("Product Added");
        }

       
        //view products in updated textboxes
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_UpdatedName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();

            tbx_UpdatedPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();

            tbx_UpdatedStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }


        //update products
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),

                Name = tbx_UpdatedName.Text,

                Price = Convert.ToDecimal(tbx_UpdatedPrice.Text),

                StockAmount =  Convert.ToInt32(tbx_UpdatedStockAmount.Text)

            };

            _productDAL.Update(product);

            LoadProducts();

            MessageBox.Show("Updated");


        }

        //delete products
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);

            _productDAL.Delete(id);

            LoadProducts();

            MessageBox.Show("Deleted");
        }
    }
}
