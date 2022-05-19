using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Partit
    {
        //atributo
        private int idPartit;
        private DateTime dataIniciPartit;
        private string estatPartit;
        private int golsLocals;
        private int golsVisitant;
        private string jornada;
        private string temporada;
        private int equipLocal;//sera la id de la clase equip
        private int equipVisitant;//sera la id de la clase equip

        //constructor
        public Partit()
        {

        }
        public Partit(DateTime iniciPartit, string estat, int golsLo, int golsVis, string jornad, string tempo, int equipoLocal, int equipoVisitante)//constructor sin clave, lo asigna la base de datos
        {
            dataIniciPartit = iniciPartit;
            estatPartit = estat;
            golsLocals = golsLo;
            golsVisitant = golsVis;
            jornada = jornad;
            temporada = tempo;
            equipLocal = equipoLocal;
            equipVisitant = equipoVisitante;
        }
        public Partit(int idpartido, DateTime iniciPartit, string estat, int golsLo, int golsVis, string jornad, string tempo, int equipoLocal, int equipoVisitante)
            : this(iniciPartit, estat, golsLo, golsVis, jornad, tempo, equipoLocal, equipoVisitante)//con id 
        {
            idPartit = idpartido;
        }
        public int IdPartit
        {
            get;
            set;
        }
        public DateTime DataIniciPartit
        {
            get;
            set;
        }
        public string EstatPartit
        {
            get;
            set;
        }
        public int GolsVisitant
        {
            get;
            set;
        }
        public int GolsLocal
        {
            get;
            set;
        }
        public string Jornada
        {
            get;
            set;
        }
        public string Temporada
        {
            get;
            set;
        }
        public int EquipLocal
        {
            get;
            set;
        }
        public int EquipVisitant
        {
            get;
            set;
        }
    }
}
