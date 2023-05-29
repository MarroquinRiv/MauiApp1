using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MauiApp1.Carros
{
    //Se hereda la clase base
    internal class muscleCar : VehiculoBase
    {
        public int cilindros { get; set; }
        public string subclase { get; set; }
        public string potencia { get; set; }
        //3 atributos unicos de la clase granTurismo

        public muscleCar(String _marca, String _modelo, String _color, int _anio,
        String _tipo, int _vmax, int _vel, int _a, int _frena, int _vrev, int _vmaxrev,
        int _cilindros, String _subclase, String _potencia) : base() //Llama al constructor de la clase base
        {
            this.cilindros = _cilindros;
            this.subclase = _subclase;
            this.potencia = _potencia;
        }

        public muscleCar()
        {
        }

        private bool rendimiento = false;

        public void comprobarRendimiento()
        {
            if (rendimiento == true)
            {
                Console.WriteLine("Balance perfecto entre rendimiento, potencia, " +
                    "y una espectacular agresividad");
            }
            else
            {
                Console.WriteLine("Error. Arreglando rendimiento.");
                Console.WriteLine("Arreglado");
                rendimiento = true;
            }
        }
        //Metodo unico de la clase muscleCar
    }
}
