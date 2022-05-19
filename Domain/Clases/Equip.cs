using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Equip
    {
        //atibuto
        private int idEquip;
        private string municipi;
        private string nomEquip;
        private string nomEstadi;
        //constructor
        public Equip()
        {

        }
        public Equip(string municipio, string nombreEquipo, string nombreEstadio)
        {
            Municipi = municipio;
            nomEquip = nombreEquipo;
            nomEstadi = nombreEstadio;
        }
        public Equip(int idEquipo, string municipio, string nombreEquipo, string nombreEstadio) : this(municipio, nombreEquipo, nombreEstadio)
        {
            idEquip = idEquipo;
        }
        //propiedades
        public int IdEquip
        {
            set { idEquip = value; }
            get { return idEquip; }
        }
        public string Municipi
        {
            set { municipi = value; }
            get { return municipi; }
        }
        public string NomEquip
        {
            set { nomEquip = value; }
            get { return nomEquip; }
        }
        public string NomEstadi
        {
            set { nomEstadi = value; }
            get { return nomEstadi; }
        }
    }
}
