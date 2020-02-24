using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.Model;
using MySql.Data.MySqlClient;
using System.Threading;

namespace PoS_System.DAO
{
    class BrandDAO
    {
        private MySqlConnection connection;
        public BrandDAO() 
        {
            string connectionString = "Server = 127.0.0.1; Port= 3306; Database=pos_project; Uid=root; Pwd=Setkl24072001";
            connection = new MySqlConnection(connectionString);
            
        }

        public List<Brand> getAllBrands() 
        {
            List<Brand> brands = new List<Brand> { };
            try
            {
                connection.Open();
                string sql = "SELECT * FROM brand";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read()) 
                {
                    
                    long id = long.Parse(rdr["ID"].ToString());
                    string name = rdr["Name"].ToString();
                    Brand brand = new Brand(id, name);
                    brands.Add(brand);
                    
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
            return brands;
        }
    }
}
