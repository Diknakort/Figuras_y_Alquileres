using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    
    public class Circulo(int valor) : IMedible
    {
        public int valor = valor;

        public int Radio { get; set; }
        public IVisionable Visor { get; set; }

        public double damePerimetro()
        { 
            return (2 * Math.PI * Radio); 
        }

        public double dameSuperficie()
        {
            return (Math.PI * Radio * Radio);
        }
        public override string? ToString()
        {
            return Visor.DameCadena(this);
        }
    }
}