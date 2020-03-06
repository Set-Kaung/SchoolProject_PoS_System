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
                        long barcode = long.Parse(rdr["Barcode"].ToString());
                        string name = rdr["Name"].ToString();
                        string description = rdr["Description"].ToString();
                        long brandID = long.Parse(rdr["Brand_ID"].ToString());
                        long categoryID = long.Parse(rdr["Category_ID"].ToString());
                        double price = double.Parse(rdr["Price"].ToString());
                        long stock = long.Parse(rdr["Stock"].ToString());
                        

                        Product product = new Product(barcode, name, description, brandID, categoryID, price, stock);
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
                command.CommandText = "INSERT INTO product (Barcode,Name,Description,Brand_ID,Category_ID,Price,Stock) VALUES(@barcode,@name,@des,@brand,@category,@price,@stock)";

                MySqlParameter barcodeParam = new MySqlParameter("@barcode", MySqlDbType.Int64, 0);
                MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.Text, 100);
                MySqlParameter desParam = new MySqlParameter("@des", MySqlDbType.Text, 100);
                MySqlParameter brandParam = new MySqlParameter("@brand", MySqlDbType.Int64, 0);
                MySqlParameter categoryParam = new MySqlParameter("@category", MySqlDbType.Int64, 0);
                MySqlParameter priceParam = new MySqlParameter("@price", MySqlDbType.Double, 0);
                MySqlParameter stockParam = new MySqlParameter("@stock", MySqlDbType.Int64, 0);

                barcodeParam.Value = product.Barcode;
                nameParam.Value = product.Name;
                desParam.Value = product.Description;
                brandParam.Value = product.BrandID;
                categoryParam.Value = product.CategoryID;
                priceParam.Value = product.Price;
                stockParam.Value = product.Stock;

                command.Parameters.Add(barcodeParam);
                command.Parameters.Add(nameParam);
                command.Parameters.Add(desParam);
                command.Parameters.Add(brandParam);
                command.Parameters.Add(categoryParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(stockParam);
                

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

        public int deleteProduct(long barcode) 
        {
            int status = 0;

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);
                command.CommandText = "DELETE FROM product WHERE Barcode=@barcode";

                MySqlParameter barcodeParam = new MySqlParameter("@id", MySqlDbType.Int64, 0);

                barcodeParam.Value = barcode;

                command.Parameters.Add(barcodeParam);

                command.Prepare();
                command.ExecuteNonQuery();

            } 
            catch (MySqlException ex) 
            {
                if (ex.ErrorCode.Equals(-2147467259))
                {
                    status = -214;
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            } 
            finally
            {
                connection.Close();
            }

            return status;
        }

        public void updateProduct(Product product) 
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);
                command.CommandText = "UPDATE product SET Name=@name,Description=@des,Brand_ID=@brand,Category_ID=@category,Price=@price,Stock=@stock WHERE Barcode=@barcode";

                MySqlParameter barcodeParam = new MySqlParameter("@barcode", MySqlDbType.Int64, 0);
                MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.Text, 100);
                MySqlParameter desParam = new MySqlParameter("@des", MySqlDbType.Text, 100);
                MySqlParameter brandParam = new MySqlParameter("@brand", MySqlDbType.Int64, 0);
                MySqlParameter categoryParam = new MySqlParameter("@category", MySqlDbType.Int64, 0);
                MySqlParameter priceParam = new MySqlParameter("@price", MySqlDbType.Double, 0);
                MySqlParameter stockParam = new MySqlParameter("@stock", MySqlDbType.Int64, 0);
                

                barcodeParam.Value = product.Barcode;
                nameParam.Value = product.Name;
                desParam.Value = product.Description;
                brandParam.Value = product.BrandID;
                categoryParam.Value = product.CategoryID;
                priceParam.Value = product.Price;
                stockParam.Value = product.Stock;
                

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
