using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Cuadrado(int valor) : IMedible
    {
        public int valor = valor;

        public IVisionable Visor { get; set; }
        public int Lado {  get; set; }
        public double damePerimetro()
        {
            return (Lado * Lado);
        }

        public double dameSuperficie()
        {
            return (Lado * 4);
        }
        public override string? ToString()
        {
            return Visor.DameCadena(this);
        }
    }
}