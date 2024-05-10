using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VisionadorConsola : IVisionable
    {
        public string DameCadena(IMedible elemento)
        {
            return($"Hola, soy un {elemento.GetType().Name}," +
                $" con un área de: {elemento.dameSuperficie()}, " +
                $"de perímetro: {elemento.damePerimetro()}");
            //Console.WriteLine("Hola, soy un " +
            //    elemento.GetType() + 
            //    " y tengo un ide de: " +
            //    elemento.Identificador + 
            //    ", mi precio / hora es: " +
            //    elemento.PrecioHora +
            //    ", he estado " +
            //    elemento.Tiempo +
            //    "y he generado " + 
            //    elemento.DameCoste());
        }
    }
}
