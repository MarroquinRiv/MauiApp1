using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MauiApp1.Carros
{
    //Se hereda la clase base
    internal class superCar : VehiculoBase
    {
        public string tecnologia { get; set; }
        public string disenio { get; set; }
        public int velocidades { get; set; }
        //3 atributos unicos de la clase superCar

        public superCar(String _marca, String _modelo, String _color, int _anio,
        String _tipo, int _vmax, int _vel, int _a, int _frena, int _vrev, int _vmaxrev,
        String _tec, String _disenio, int _velocidades) : base() //Llama al constructor de la clase base
        {
            this.tecnologia = _tec;
            this.disenio = _disenio;
            this.velocidades = _velocidades;
        }

        public superCar()
        {
        }

        public void cambiarVelocidad()
        {
            Console.WriteLine("Velocidad con 7 cambios, elija uno: ");
            velocidades = Convert.ToInt32(Console.ReadLine());
            while (velocidades<1||velocidades >7)
            {
                Console.WriteLine("Ups, te pasaste, prueba de nuevo: ");
                velocidades = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Caja de cambios en velociad "+velocidades);

        }
        //Metodo unico de la clase superCar
    }
}
