using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MauiApp1.Carros
{
    //Se hereda la clase base
    internal class granTurismo : VehiculoBase
    {
        public int peso { get; set; }
        public int puertas { get; set; }
        public int carrerasGanadas { get; set; }
        //3 atributos unicos de la clase granTurismo

        public granTurismo(String _marca, String _modelo, String _color, int _anio,
        String _tipo, int _vmax, int _vel, int _a, int _frena, int _vrev, int _vmaxrev,
        int _peso, int _puertas, int _carrerasGanadas) : base() //Llama al constructor de la clase base
        {
            this.peso = _peso;
            this.puertas = _puertas;
            this.carrerasGanadas = _carrerasGanadas;
        }

        public granTurismo()
        {
        }

        private bool turnCarrera = false;

        public void ganarCarrera()
        {
            if (turnOn == false)
            {
                Console.WriteLine("El carro esta apagado");
            }
            else
            {
                if (_vel < 200)
                {
                    turnCarrera = false;
                    Console.WriteLine("Perdiste, te falta velocidad");
                }
                else
                {
                    turnCarrera = true;
                    Console.WriteLine("Ganaste");
                    Console.WriteLine("Carreras ganadas: " + carrerasGanadas);
                    carrerasGanadas++;
                }
            }
        }
        //Metodo unico de la clase granTurismo
    }
}
