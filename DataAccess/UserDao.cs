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

        //METODO PARA AÑADIR UN PARTIDO
        public bool AñadirPartido(string equipLocal, string equipVisitant, string estatPartit, int golLocal, int golVisitant, string jornada, string temporada, DateTime fechaPartido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    //CREAMOS LA SELECT Y COMPROBAMOS
                    command2.Connection = connection;
                    command2.CommandText = $"select * from partit where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI TIENE ALGUNA LINEA ESTA SELECT, ES QUE EL PARTIDO YA EXISTE, ERROR!
                    if (reader2.HasRows)
                    {
                        return true;
                    }
                    //SI NO HACEMOS EL INSERT DEL NUEVO PARTIDO
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


        //METODO PARA ELIMINAR PARTIDO
        public bool EliminarPartido(string equipLocal, string equipVisitant, string temporada)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    //CREAMOS LA SELECR PARA COMROBAR QUE EXISTE EL PARTIDO
                    command2.Connection = connection;
                    command2.CommandText = $"select * from partit where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI EL PARTIDO NO EXISTE, ERROR, YA QUE NO SE PODRA ELIMINAR
                    if (!reader2.HasRows)
                    {
                        return false;
                    }
                    //SI NO BORRAMOS EL PARTIDO CON ESTA COMANDA
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

        //METODO PARA ELIMINAR USUARIO
        public string EliminarUser(string user)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    //CREAMOS LA SELECT PARA VER SI EXISTE EL USUARIO
                    command2.Connection = connection;
                    command2.CommandText = $"select * from usuari where alias = '{user}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI EL USUARIO QUE NOS INTENTA ELIMINAR ES EL ADMIN, LE MOSTRAMOS MENSAJE DE ERROR
                    if (user == "admin" || user == "Admin" || user == "ADMIN")
                    {                        
                        return "0";
                    }
                    //SI LA SELECT NO TIENE LINEAS, USUARIO INEXISTENTE, ERROR, NO SE PUEDE ELIMINAR
                    else
                    {
                        if (!reader2.HasRows)
                        {
                            return "1";
                        }
                        //SI NO, ELIMINAMOS USUARIO CON ESTE DELETE
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

        //METODO PARA AÑADIR EQUIPP
        public bool AñadriEquipo(string nomEquip, string nomEstadi, string municipi)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    //CREAMOS UNA SELECT PARA VER QUE NO REPITA EL EQUIPO
                    command2.Connection = connection;
                    command2.CommandText = $"select * from equip where nomEquip = '{nomEquip}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI DEVULEVE ALGUNA LINEA, ERROR YA QUE EXISTE EL EQUIPO
                    if (reader2.HasRows)
                    {
                        return true;
                    }
                    //SINO HACEMOS EL INSERT DEL NUEVO EQUIPO
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

        //METODO PARA ELIMIANR EQUIPO
        public bool EliminarEquipo(string nomEquip)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    //CREAMOS UNA SELECT PARA COMPROBAR SI EXISTE EL EQUIPO
                    command2.Connection = connection;
                    command2.CommandText = $"select * from Equip where nomEquip = '{nomEquip}'";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI NO DEVUELVE NINGUNA LINEA, ERROR, NO EXISTE EL EQUIPO QUE QUEREMOS ELIMINAR
                    if (!reader2.HasRows)
                    {
                        return false;
                    }
                    //SI NO HACEMOS ESTE DELETE PARA ELIMINAR EL EQUIPO
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

        //METODO PARA CREAR USUARIO
        public bool CrearUsaurio(string nombre, string apellidos, string alias, string password, string nif)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command2 = new MySqlCommand())
                {
                    //CREAMOS UNA SELECT PARA COMPRBAR QUE NO REPITE EL USUARIO
                    command2.Connection = connection;
                    command2.CommandText = $"select * from Usuari where alias = '{alias}'";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI DEVUELVE ALGUNA FILA, ERROR, NO PUEDE CREAR EL USUARIO CON EL MISMO ALIAS NI NIF/DNI
                    if (reader2.HasRows)
                    {
                        return true;
                    }
                    //SINO CREAMOS EL USUARIO CON ESTA INSERT
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

        //METODO PARA ACCEDER A AJUSTES DE UN PARTIDO YA CREADO
        public bool AccederEditarPartidoCreado(string equipLocal, string equipVisitant, string temporada, int golLocal, int golVisitant, string estat)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command2 = new MySqlCommand())
                {
                    //CREO UNA SELECT PARA COMPROBAR QUE EXISTE EL PARTIDO
                    command2.Connection = connection;
                    command2.CommandText = $"select * from Partit where nomEquipLocal = '{equipLocal}' and nomEquipVisitant = '{equipVisitant}' and temporada = '{temporada}'";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI NO NOS DEVUELVUE NINGUNA FILA, ERROR, YA QUE NO EXISTE EL PARTIDO
                    if (!reader2.HasRows)
                    {
                        return false;
                    }
                    //SI EXISTE, HACEMOS LOS CAMBIOS QUE DESEAMOS, CON ESTA SELECT
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

        //METODO PARA CREAR PORRAS
        public string CrearPorra(string alias, int idPartit, int golLocal, int golVisitant)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command2 = new MySqlCommand())
                {
                    //COMPRUEBO QUE CREA LA PORRA CON UN USUARIO CORRECTO
                    command2.Connection = connection;
                    command2.CommandText = $"select * from Usuari where alias = '{alias}';";
                    command2.CommandType = CommandType.Text;
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    //SI NO DEVUELVE NADA LA SELECT, EL USUARIO ES INCORRECTO, NO SE HACE LA PORRA
                    if (!reader2.HasRows)
                    {
                        return "1";
                    }
                    else
                    {
                        //CREAMOS OTRA SELECT PARA VER SI EXISTE EL PARTIDO POR EL QUE QUIERE APOSTAR
                        reader2.Close();
                        var command3 = new MySqlCommand();
                        command3.Connection = connection;
                        command3.CommandText = $"select * from partit where idPartit = '{idPartit}';";
                        command3.CommandType = CommandType.Text;
                        MySqlDataReader reader3 = command3.ExecuteReader();
                        //SI NO DEVUELVE NADA, ERROR, YA QUE EL PARTIDO POR EL CUAL QUIERE APOSTAR NO EXITSE
                        if (!reader3.HasRows)
                        {
                            return "2";
                        }
                        else
                        {
                            //AHORA COMPRUEBO QUE LOS GOLES NO SEAN NEGATIVOS
                            reader3.Close();
                            if(golLocal < 0 || golVisitant < 0)
                            {
                                return "3";
                            }
                            else
                            {
                                //SI TODOS LOS DATOS ANTERIORES SON CORRECTOS, HACEMOS EL INSERT DE LA PORRA 
                                var command = new MySqlCommand();
                                command.Connection = connection;
                                command.CommandText = $"insert into porra values('{alias}', '{idPartit}', '{golLocal}', '{golVisitant}', current_timestamp, null);";
                                command.CommandType = CommandType.Text;
                                MySqlDataReader reader = command.ExecuteReader();
                                return "4";
                            }
                        }
                    }
                }
            }
        }
    }
}
