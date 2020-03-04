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

        public void addProduct(Product product) 
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);
                command.CommandText = "INSERT INTO product (Name,Description,Brand_ID,Category_ID,Price,Stock,Barcode) VALUES(@name,@des,@brand,@category,@price,@stock,@barcode)";

                MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.Text, 100);
                MySqlParameter desParam = new MySqlParameter("@des", MySqlDbType.Text, 100);
                MySqlParameter brandParam = new MySqlParameter("@brand", MySqlDbType.Int64, 0);
                MySqlParameter categoryParam = new MySqlParameter("@category", MySqlDbType.Int64, 0);
                MySqlParameter priceParam = new MySqlParameter("@price", MySqlDbType.Double, 0);
                MySqlParameter stockParam = new MySqlParameter("@stock", MySqlDbType.Int64, 0);
                MySqlParameter barcodeParam = new MySqlParameter("@barcode", MySqlDbType.Int64, 0);

                nameParam.Value = product.Name;
                desParam.Value = product.Description;
                brandParam.Value = product.BrandID;
                categoryParam.Value = product.CategoryID;
                priceParam.Value = product.Price;
                stockParam.Value = product.Stock;
                barcodeParam.Value = product.Barcode;

                command.Parameters.Add(nameParam);
                command.Parameters.Add(desParam);
                command.Parameters.Add(brandParam);
                command.Parameters.Add(categoryParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(stockParam);
                command.Parameters.Add(barcodeParam);

                command.Prepare();
                command.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                connection.Close();
            }
        }
        

    }
}
