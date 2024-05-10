using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public class VisionadorHTML : IVisionable
    {
        public string DameCadena(IAlquilable elemento)
        {
            Console.WriteLine($"<p>Hola, soy un {elemento.GetType()} y tengo un ide de: {elemento.Identificador}, mi <b>precio / hora</b> es: {elemento.PrecioHora}, he estado {elemento.Tiempo} y he generado {elemento.DameCoste()}</p>");
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
