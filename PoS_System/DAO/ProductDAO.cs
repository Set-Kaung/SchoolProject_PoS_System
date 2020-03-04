using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PoS_System.Model;

namespace PoS_System.DAO
{
    class ProductDAO
    {
        private MySqlConnection connection;
        private Connector connector = new Connector();
        public ProductDAO()
        {
            connection = connector.Connection;

        }
            public List<Product> getAllProducts() {
            List<Product> products = new List<Product>();
            try
                {
                    connection.Open();
                    string sql = "SELECT * FROM product";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        long id = long.Parse(rdr["ID"].ToString());
                        string name = rdr["Name"].ToString();
                        string description = rdr["Description"].ToString();
                        long brandID = long.Parse(rdr["Brand_ID"].ToString());
                        long categoryID = long.Parse(rdr["Category_ID"].ToString());
                        double price = double.Parse(rdr["Price"].ToString());
                        long stock = long.Parse(rdr["Stock"].ToString());
                        long barcode = long.Parse(rdr["Barcode"].ToString());

                        Product product = new Product(id, name, description, brandID, categoryID, price, stock, barcode);
                        products.Add(product);

                    }
                }

                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
                return products;
            }
        

    }
}
