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
        private Connector connector = new Connector();
        public CategoryDAO()
        {
            connection = connector.Connection;

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
        public void updateCategory(long id, string name)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);

                command.CommandText = "UPDATE category SET Name=@name WHERE ID=@id";

                MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.Int64, 0);
                MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.Text, 100);

                idParam.Value = id;
                nameParam.Value = name;

                command.Parameters.Add(idParam);
                command.Parameters.Add(nameParam);

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
        public int deleteCategory(long id)
        {
            int status = 0;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);
                command.CommandText = "DELETE FROM category WHERE ID=@id";

                MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.Int64, 0);

                idParam.Value = id;
                command.Parameters.Add(idParam);

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
        public void addCategory(string name)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);

                command.CommandText = "INSERT INTO category (Name) VALUES(@name)";

              
                MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.Text, 100);

                nameParam.Value = name;

                command.Parameters.Add(nameParam);

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
