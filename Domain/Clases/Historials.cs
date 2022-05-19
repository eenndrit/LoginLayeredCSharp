using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Historials
    {
        //atributo
        private List<Historial> historia;
        //constructor
        public Historials()
        {
            historia = new List<Historial>();
        }
        public Historials(List<Historial> histori) : this()
        {
            historia = histori;
        }
        //propiedad
        public List<Historial> Historiales
        {
            get;
            set;
        }
    }
}
