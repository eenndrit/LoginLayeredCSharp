using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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
    }
}
