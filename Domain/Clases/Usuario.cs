using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Usuario
    {
        //atributos
        private string alias;
        private string cognoms;
        private DateTime dataAlta;
        private string nif;
        private string password;
        //propiedades
        public string Alias
        {
            set { alias = value; }
            get { return alias; }
        }
        public string Cognoms
        {
            set { cognoms = value; }
            get { return cognoms; }
        }
        public DateTime DataAlta
        {
            set { dataAlta = value; }
            get { return dataAlta; }
        }
        public string Nif
        {
            set { nif = value; }
            get { return nif; }
        }
        public string Password
        {
            set { nif = value; }
            get { return nif; }
        }
    }
}
