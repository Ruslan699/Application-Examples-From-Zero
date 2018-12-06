using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ProductDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=DESKTOP-VQIJ8KV\SQLEXPRESS; initial catalog=ShopDB; integrated security = true");
        //very basic and oldfashioned way
        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            // read each datas from reader
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),

                    Name = reader["Name"].ToString(),

                    StockAmount = Convert.ToInt32(reader["StockAmount"]),

                    Price = Convert.ToDecimal(reader["Price"])
                };

                products.Add(product);
            }

            reader.Close();

            _connection.Close();

            return products;
        }

        //Database connection extract method
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        //Get Product List with DataTable
        public DataTable GetAll2()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            //not preferred way(I want to show basic way Product List with Ado.Net)
            DataTable data = new DataTable();

            data.Load(reader);

            reader.Close();

            _connection.Close();

            return data;
        }


        //Add Product
        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("Insert into Products values(@name, @price, @stockAmount)", _connection);


            //Secure from Sql Injection
            sqlCommand.Parameters.AddWithValue("@name", product.Name);

            sqlCommand.Parameters.AddWithValue("@price", product.Price);

            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("Update Products set Name = @name, Price = @price, StockAmount = @stockAmount where Id=@id", _connection);


            //Secure from Sql Injection
            sqlCommand.Parameters.AddWithValue("@name", product.Name);

            sqlCommand.Parameters.AddWithValue("@price", product.Price);

            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            sqlCommand.Parameters.AddWithValue("@id", product.Id);

            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete (int id)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("Delete from Products where Id= @id", _connection);

            sqlCommand.Parameters.AddWithValue("@id", id);
            
            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
