using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Penyistes
    {
        //atributo
        private List<Penyista> llistaPenyistas;
        //constructores
        public Penyistes()
        {
            llistaPenyistas = new List<Penyista>();
        }
        public Penyistes(List<Penyista> penyias) : this()
        {
            llistaPenyistas = penyias;
        }
        //Propiedades
        public List<Penyista> LlistaPenyistes
        {
            get { return llistaPenyistas; }
            set { llistaPenyistas = value; }
        }
    }
}
