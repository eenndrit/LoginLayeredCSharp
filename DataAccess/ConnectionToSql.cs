using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        //CREO EL STRING EN FORMATO READONLY YA QUE SOLO SE PODRA LEER
        private readonly string connectionString;

        //CREO EL 'LINK' PARA ACCEDER A LA BASE DE DATOS
        public ConnectionToSql()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=porra";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable ConsultarPartidos()
        {
            string query = "select * from partit";
            MySqlCommand cmd = new MySqlCommand(query, GetConnection());
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public DataTable ConsultarPorras()
        {
            string query = "select * from porra";
            MySqlCommand cmd = new MySqlCommand(query, GetConnection());
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
    }
}
