using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Porras
    {
        private List<Porra> llistaPorras;
        //constructores
        public Porras()
        {
            llistaPorras = new List<Porra>();
        }
        public Porras(List<Porra> listaDePorras) : this()
        {
            llistaPorras = listaDePorras;
        }
    }
}
