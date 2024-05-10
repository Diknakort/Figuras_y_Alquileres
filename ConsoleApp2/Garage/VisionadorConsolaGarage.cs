using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public class VisionadorConsolaGarage : IVisionable
    {
        public string DameCadena(IAlquilable elemento)
        {
            Console.WriteLine($"Hola, soy un {elemento.GetType()} y tengo un ide de: {elemento.Identificador}, mi precio / hora es: {elemento.PrecioHora}, he estado {elemento.Tiempo} y he generado {elemento.DameCoste()}");
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
