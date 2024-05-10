using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Modelo
{
    internal class Vehiculo
    {
        public Vehiculo() { }

        public Vehiculo(double potencia, int numRuedas, double velocidad)
        {
            this.potencia = potencia;
            this.numRuedas = numRuedas;
            this.velocidad = velocidad;
        }

        public double potencia { get; set; }
        public int numRuedas { get; set; } = 4;
        public double velocidad { get; set; }


        public override string ToString()
        {
            return "Potencia: " + potencia + ", nº Ruedas: " + numRuedas + " y Velocidad: " + velocidad;
        }

        //public override bool Equals(object? obj)
        //{
        //    return obj is Vehiculo vehiculo && potencia == vehiculo.potencia;
        //}

        //// public int CompareTo(Coche other) => this.Matricula.CompareTo(other.Matricula);

        //public int CompareTo(Vehiculo other)
        //{
        //    return this.potencia.CompareTo(other.potencia);
        //}
    }
}

