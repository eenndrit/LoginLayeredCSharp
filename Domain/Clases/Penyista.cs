using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Penyista:Usuario
    {
        //atributos
        private int idPenyista;
        //hereda atributos y propiedades de usuario

        //propiedades
        public int Idpenista
        {
            set { idPenyista = value; }
            get { return idPenyista; }
        }
        public Penyista()
        {

        }
        public Penyista(string alia, string segundoNombre, DateTime dataInicio, string nifUsuario, string clave)
        {
            Alias = alia;
            Cognoms = segundoNombre;
            DataAlta = dataInicio;
            Nif = nifUsuario;
            Password = clave;
        }
        public Penyista(int idPenya, string alia, string segundoNombre, DateTime dataInicio, string nifUsuario, string clave) : this(alia, segundoNombre, dataInicio, nifUsuario, clave)
        //reutiliza el anterior constructor
        {
            idPenyista = idPenya;
        }
    }
}
