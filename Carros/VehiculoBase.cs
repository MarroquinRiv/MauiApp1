using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MauiApp1.Carros
{
    //Se hereda de la interfaz IVehiculo
    public class VehiculoBase : IVehiculo
    {
        public string duenio { get; set; }
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

        //Se define la clase privada placa para el carro
        private class placa
        {
            private string placaNum;

            public string PlacaNum
            {
                get { return placaNum; }
                set { placaNum = value; }
            }
        }

        //Constructor de la clase VehiculoBase
        public VehiculoBase(String _duenio, String _marca, String _modelo, String _color, int _anio,
        String _tipo, int _vmax, int _vel, int _a, int _frena, int _vrev, int _vmaxrev)
        {
            this.duenio = _duenio;
            this.marca = _marca;
            this.modelo = _modelo;
            this.color = _color;
            this.anio = _anio;
            this.tipo = _tipo;
            this.velocidadMaxima = _vmax = 340;
            this.velocidadActual = _vel;
            this.aceleracion = _a;
            this.frenado = _frena;
            this.velocidadReversa = _vrev = 10;
            this.velocidadMaximaReversa = _vmaxrev = 40;
        }

        public VehiculoBase()
        {
        }

        //El carro empieza con todos los atributos en falso (apagados) o desde cero
        public bool turnOn = false;
        public bool turnLuces = false;
        public bool turnRadio = false;
        public bool turnBocina = false;
        public bool turnAcelerar = false;
        public bool turnFrenar = false;
        public bool turnReversa = false;
        public int _vel = 0;

        //Métodos con validación de funcionamiento, por ejemplo,
        //no se puede acelerar si el carro no está encendido.
        public void luces()
        {
            if (turnLuces == false)
            {
                turnLuces = true;
                Console.WriteLine("Luces encendidas");
            }
            else
            {
                turnLuces = false;
                Console.WriteLine("Luces apagadas");
            }
        }
        public void radio()
        {
            if (turnRadio == false)
            {
                turnRadio = true;
                Console.WriteLine("Radio encendido");
            }
            else
            {
                turnRadio = false;
                Console.WriteLine("Radio apagado");
            }
        }
        public void bocina()
        {
            if (turnRadio == false)
            {
                turnRadio = true;
                Console.WriteLine("Bocina encendida");
            }
            else
            {
                turnRadio = false;
                Console.WriteLine("Bocina apagada");
            }
        }
        public void acelerar(int cuanto)
        {
            if (turnOn == false)
            {
                Console.WriteLine("El carro está apagado, prueba a encenderlo.");
            }
            else
            {
                if (_vel == velocidadMaxima)
                {
                    Console.WriteLine("El carro está a su velocidad máxima");
                }
                else
                {
                    turnAcelerar = true;
                    _vel += cuanto;
                    Console.WriteLine("Acelerando");
                }
            }
        }
        public void encender()
        {
            if (turnOn == false)
            {
                turnOn = true;
                Console.WriteLine("Carro encendido");
            }
            else
            {
                Console.WriteLine("El carro ya estaba encendido");
            }
        }
        public void apagar()
        {
            if (turnOn == false)
            {
                Console.WriteLine("El carro ya estaba apagado");
            }
            else
            {
                turnOn = false;
                Console.WriteLine("Carro apagado");
            }
        }
        public void frenar(int cuanto)
        {
            if (turnOn == false)
            {
                Console.WriteLine("El carro está apagado, prueba a encenderlo.");
            }
            else
            {
                if (_vel > 0)
                {
                    turnFrenar = true;
                    _vel -= cuanto;
                    Console.WriteLine("Frenando");
                }
                else
                {
                    Console.WriteLine("El carro está detenido");
                }
            };
        }
        public void reversa(int cuanto)
        {
            if (_vel == 0 && turnReversa == false)
            {
                turnReversa = true;
                _vel -= cuanto;
                Console.WriteLine("Reversa");
            }
            else
            {
                Console.WriteLine("El carro está en movimiento");
            }
        }
    }
}
