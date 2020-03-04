using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.Model;
using MySql.Data.MySqlClient;

namespace PoS_System.DAO
{
    class BrandDAO
    {
        private MySqlConnection connection;
        private Connector connector = new Connector();

        public BrandDAO() 
        {
            connection = connector.Connection;
        }

        public List<Brand> getAllBrands() 
        {
            List<Brand> brands = new List<Brand>();

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
        public void updateBrand(long id, string name)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);

                command.CommandText = "UPDATE brand SET Name=@name WHERE ID=@id";

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
        public int deleteBrand(long id)
        {
            int status = 0;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);
                command.CommandText = "DELETE FROM brand WHERE ID=@id";

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
        public void addBrand(string name)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);

                command.CommandText = "INSERT INTO brand (Name) VALUES (@name)";


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
