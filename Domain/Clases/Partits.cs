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
        //metodos
        public bool ComprobarSiExiste(Partit partidos)
        {
            //Comprobamos que un mismo e
            bool existe = llistaPartits.Any(p => p.EquipLocal == partidos.EquipLocal);
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.findall?view=net-6.0#system-collections-generic-list-1-findall(system-predicate((-0)))
            //a traves de la base de datos puedo ver si hay mas de 2
            if (existe == true)
            {
                existe = llistaPartits.Any(Partit => Partit.EquipVisitant == partidos.EquipVisitant);
                return existe;
            }
            return existe;

        }
    }
}
