using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Equips
    {
        //atributo
        private List<Equip> llistaEquips;
        //constructor
        public Equips()
        {
            llistaEquips = new List<Equip>();
        }
        public Equips(List<Equip> listaDeEquip) : this()
        {
            llistaEquips = listaDeEquip;
        }
        //propiedad
        public List<Equip> LlistaEquip
        {
            get { return llistaEquips; }
            set { llistaEquips = value; }
        }
    }
}
