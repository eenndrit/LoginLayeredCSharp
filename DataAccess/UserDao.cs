using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class UserDao:ConnectionToSql
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=porra";

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"select * from Usuari where alias='{user}' and password='{pass}';";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }
    }
}
