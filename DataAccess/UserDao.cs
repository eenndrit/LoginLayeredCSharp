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
                        string dataPartit = fechaPartido.ToString("yyyy-MM-dd HH-mm-ss");
                        reader2.Close();
                        var command = new MySqlCommand();
                        command.Connection = connection;
                        command.CommandText = $"insert into partit(nomEquipLocal, nomEquipVisitant, dataIniciPartit, estatPartit, golsLocal, golsVisitant, jornada, temporada) \n" +
                                                  $"values('{equipLocal}','{equipVisitant}','{dataPartit}','{estatPartit}','{golLocal}','{golVisitant}','{jornada}','{temporada}')";
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

        public string EliminarUser(string user)
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
                    if (user == "admin" || user == "Admin" || user == "ADMIN")
                    {                        
                        return "0";
                    }
                    else
                    {
                        if (!reader2.HasRows)
                        {
                            return "1";
                        }
                        else
                        {
                            reader2.Close();
                            var command = new MySqlCommand();
                            command.Connection = connection;
                            command.CommandText = $"delete from usuari where alias = '{user}'";
                            command.CommandType = CommandType.Text;
                            MySqlDataReader reader = command.ExecuteReader();
                            return "2";
                        }
                }
            }
            }
        }

        public bool AñadriEquipo(string nomEquip, string nomEstadi, string municipi)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = $"select * from equip where nomEquip = '{nomEquip}';";
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
                        command.CommandText = $"insert into Equip(nomEquip, nomCamp, municipi) values('{nomEquip}', '{nomEstadi}', '{municipi}')";
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        return false;
                    }
                }
            }
        }

        public bool EliminarEquipo(string nomEquip)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = $"select * from Equip where nomEquip = '{nomEquip}'";
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
                        command.CommandText = $"Delete from Equip where nomEquip = '{nomEquip}';";
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        return true;
                    }
                }
            }
        }

        public bool CrearUsaurio(string nombre, string apellidos, string alias, string password, string nif)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command2 = new MySqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = $"select * from Usuari where alias = '{alias}'";
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
                        command.CommandText = $"INSERT INTO Usuari(nom, cognoms, nif, alias, password, dataAlta) VALUES('{nombre}', '{apellidos}', '{nif}', '{alias}', '{password}', current_timestamp);";
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        return false;
                    }
                }
            }
        }

        public bool AccederEditarPartidoCreado(string equipLocal, string equipVisitant, string temporada, int golLocal, int golVisitant, string estat)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = $"select * from Partit where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}'";
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
                        command.CommandText = $"update partit set golsLocal = '{golLocal}', golsVisitant = '{golVisitant}', estatPartit = '{estat}'\n" +
                                              $"where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}';";
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        return true;
                    }
                }
            }
        }
    }
}
