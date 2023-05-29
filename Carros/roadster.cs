using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MauiApp1.Carros
{
    //Se hereda la clase base
    internal class roadster : VehiculoBase
    {
        public string motor { get; set; }
        public string traccion { get; set; }
        public string suspension { get; set; }
        //3 atributos unicos de la clase roadster

        public roadster(String _marca, String _modelo, String _color, int _anio,
        String _tipo, int _vmax, int _vel, int _a, int _frena, int _vrev, int _vmaxrev,
        String _motor, String _traccion, String _suspension) : base() //Llama al constructor de la clase base
        {
            this.motor = _motor;
            this.traccion = _traccion;
            this.suspension = _suspension;
        }

        public roadster()
        {
        }

        private bool turnDescapotar = false;

        public void descapotar()
        {
            if (turnDescapotar == false)
            {
                turnDescapotar = true;
                Console.WriteLine("El carro está descapotado");
            }
            else
            {
                turnDescapotar = false;
                Console.WriteLine("El carro está descapotado");
            }
        }
        //Metodo unico de la clase roadster
    }
}
