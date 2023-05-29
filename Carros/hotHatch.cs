using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MauiApp1.Carros
{
    //Se hereda la clase base
    internal class hotHatch : VehiculoBase
    {
        public string carroceria { get; set; }
        public string produccion { get; set; }
        public string garantia { get; set; }
        //3 atributos unicos de la clase hotHatch

        public hotHatch(String _marca, String _modelo, String _color, int _anio,
        String _tipo, int _vmax, int _vel, int _a, int _frena, int _vrev, int _vmaxrev,
        String _carroceria, String _produccion, String _garantia) : base() //Llama al constructor de la clase base
        {
            this.carroceria = _carroceria;
            this.produccion = _produccion;
            this.garantia = _garantia;
        }

        public hotHatch()
        {
        }

        private bool turnQR = false;

        public void quemarRueda()
        {
            if (turnQR == false)
            {
                turnQR = true;
                Console.WriteLine("Quemando rueda");
            }
            else
            {
                turnQR = false;
                Console.WriteLine("Rueda no quemada");
            }
        }
        //Metodo unico de la clase hot hatch
    }
}
