using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PoS_System.Model;


namespace PoS_System.DAO
{
    class StaffDAO
    {
        private MySqlConnection connection;
        public StaffDAO()
        {
            string connectionString = "Server = 127.0.0.1; Port= 3306; Database=pos_project; Uid=root; Pwd=Setkl24072001";
            connection = new MySqlConnection(connectionString);
        }
        public List<Staff> getAllStaffs()
        {
            List<Staff> staffs = new List<Staff>();
            try
            {
                connection.Open();
                string sql = "SELECT * FROM staff";
                MySqlCommand command = new MySqlCommand(sql,connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read()) 
                {
                    long id = long.Parse(rdr["ID"].ToString());
                    string name = rdr["Name"].ToString();
                    string password = rdr["Password"].ToString();

                    Staff staff = new Staff(id, name, password);
                    staffs.Add(staff);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                connection.Close();
            }
            return staffs;
        }
        public void addStaff(string username, string hashedPassword) 
        {
            string name = username;
            string password = hashedPassword; //this will accept hased password from the service layer
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(null, connection);
                command.CommandText =
                "INSERT INTO staff(Name, Password) " +
                "VALUES (@name, @pwd)";
                MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.Text, 100);
                MySqlParameter pwdParam = new MySqlParameter("@pwd", MySqlDbType.Text, 100);

                nameParam.Value = name;
                pwdParam.Value = password;

                command.Parameters.Add(nameParam);
                command.Parameters.Add(pwdParam);

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
