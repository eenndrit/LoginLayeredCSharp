using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Admin:Usuario
    {
        //atributos
        private int idAdmin;
        //Coge atributos y propiedades de usuario
        public int IdAdmin
        {
            set { idAdmin = value; }
            get { return idAdmin; }
        }
        //constructor
        public Admin()
        {

        }
        public Admin(string alia, string segundoNombre, DateTime dataInicio, string nifUsuario, string clave)
        {
            Alias = alia;
            Cognoms = segundoNombre;
            DataAlta = dataInicio;
            Nif = nifUsuario;
            Password = clave;
        }
        public Admin(int idPenya, string alia, string segundoNombre, DateTime dataInicio, string nifUsuario, string clave) : this(alia, segundoNombre, dataInicio, nifUsuario, clave)
        //reutiliza el anterior constructor
        {
            idAdmin = idPenya;
        }
    }
}
