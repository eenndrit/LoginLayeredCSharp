using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Partits
    {
        //atributo
        private List<Partit> llistaPartits;
        //constructores
        public Partits()
        {
            llistaPartits = new List<Partit>();
        }
        public Partits(List<Partit> llistaDePartits) : this()
        {
            llistaPartits = llistaDePartits;
        }
        //propiedad
        public List<Partit> LlistaPartits
        {
            get { return llistaPartits; }
            set { llistaPartits = value; }
        }
    }
}
