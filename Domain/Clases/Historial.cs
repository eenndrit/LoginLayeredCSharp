using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    class Historial
    {
        //atributos
        private string temporada;
        private int puntuacioTotal;
        //constructor
        public Historial()
        {

        }
        public Historial(string temporadaDeJuego, int puntuacio)
        {
            temporada = temporadaDeJuego;
            puntuacioTotal = puntuacio;
        }
        //propiedades
        public string Temporada
        {
            get;
            set;
        }
        public int PuntuacioTotal
        {
            get;
            set;
        }
    }
}
