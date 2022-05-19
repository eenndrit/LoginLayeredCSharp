using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Porra
    {
        //atributo
        private int idPorra;
        private int golsLocals;
        private int golsVisitants;
        private DateTime dataPorra;//Esta data sive para comprovar que el partido no haya empezado y haga un apuesta
        private int idPartit;//esta id viene de la clase partit y es para saber a que partido esta haciendo la apuesta
        private int idPenyista;//esta id viene de la clase penyista y es para saber que usuario esta haciendo la apuesta
        //constructor
        public Porra()
        {

        }
        public Porra(int golsLoc, int golsVis, DateTime dataActual, int idjuegoFut, int idpenya)
        {
            golsLocals = golsLoc;
            golsVisitants = golsVis;
            dataPorra = dataActual;
            idPartit = idjuegoFut;
            idPenyista = idpenya;
        }
        public Porra(int idApuesta, int golsLoc, int golsVis, DateTime dataActual, int idFut, int idpenya)
            : this(golsLoc, golsVis, dataActual, idFut, idpenya)
        {
            idPorra = idApuesta;
        }
    }
}
