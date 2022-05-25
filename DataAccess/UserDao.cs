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

        //METODO LOGIN 
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    //CON ESTA SELECT COMPRUEBO SI EL USUARIO EXISTE
                    command.CommandText = $"select * from Usuari where alias='{user}' and password='{pass}';";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    //SI CONTIENE LINEAS LA SELECT ES QUE EXISTE EL USER, SINO NO EXISTE
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }
        public bool AñadirPartido(string equipLocal, string equipVisitant, string estatPartit, int golLocal, int golVisitant, string jornada, string temporada, DateTime fechaPartido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = $"select * from partit where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        reader2.Close();
                        var command = new MySqlCommand();
                        command.Connection = connection;
                        command.CommandText = $"insert into partit(nomEquipLocal, nomEquipVisitant, dataIniciPartit, estatPartit, golsLocal, golsVisitant, jornada, temporada) \n" +
                                                  $"values('{equipLocal}','{equipVisitant}','{fechaPartido}','{estatPartit}','{golLocal}','{golVisitant}','{jornada}','{temporada}')";
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        return false;
                    }
                }

            }
        }

        public bool EliminarPartido(string equipLocal, string equipVisitant, string temporada)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = $"select * from partit where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    if (!reader2.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        reader2.Close();
                        var command = new MySqlCommand();
                        command.Connection = connection;
                        command.CommandText = $"delete from partit where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}';";
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        return true;
                    }
                }
            }
        }

        public bool EliminarUser(string user)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = $"select * from usuari where alias = '{user}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //if(user == "admin" || user == "Admin")
                    //{
                    //    bool userAdmin = true;
                    //    return userAdmin;
                    //}
                    //else
                    //{
                        if (!reader2.HasRows)
                        {
                            return false;
                        }
                        else
                        {
                            reader2.Close();
                            var command = new MySqlCommand();
                            command.Connection = connection;
                            command.CommandText = $"delete from usuari where alias = '{user}'";
                            command.CommandType = CommandType.Text;
                            MySqlDataReader reader = command.ExecuteReader();
                            return true;
                        }
                    //}
                }
            }
        }
    }
}
