using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Carros
{
    internal interface IVehiculo
    {
        string duenio { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int anio { get; set; }
        public string tipo { get; set; }
        public int velocidadMaxima { get; }
        public int velocidadActual { get; }
        public int aceleracion { get; set; }
        public int frenado { get; set; }
        public int velocidadReversa { get; }
        public int velocidadMaximaReversa { get; }
        void luces();
        void radio();
        void bocina();
        void acelerar(int cuanto);
        void encender();
        void apagar();
        void frenar(int cuanto);
        void reversa(int cuanto);
    }
}
