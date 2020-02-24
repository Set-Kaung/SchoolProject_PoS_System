using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PoS_System.Model;

namespace PoS_System.DAO
{
    class CategoryDAO
    {
        private MySqlConnection connection;
        public CategoryDAO()
        {
            string connectionString = "Server = 127.0.0.1; Port= 3306; Database=pos_project; Uid=root; Pwd=Setkl24072001";
            connection = new MySqlConnection(connectionString);

        }

        public List<Category> getAllCategories() 
        {
            List<Category> categories = new List<Category>();
            try
            {
                connection.Open();
                string sql = "SELECT * FROM category";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    long id = long.Parse(rdr["ID"].ToString());
                    string name = rdr["Name"].ToString();
                    Category category = new Category(id, name);
                    categories.Add(category);
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
            return categories;
        }

    }
}
