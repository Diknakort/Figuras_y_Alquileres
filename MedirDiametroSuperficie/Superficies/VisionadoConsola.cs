using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedirDiametroSuperficie.Superficies
{
    public class VisionadorConsola : IVisionable
    {
        public string DameCadena(IMedible elemento)
        {
            Console.WriteLine($"Hola, soy un {elemento.GetType()} y tengo un {elemento.DameSuperficie()}");
            //Console.WriteLine("Hola, soy un " +
            //    elemento.GetType() + 
            //    " y tengo un ide de: " +
            //    elemento.Identificador + 
            //    ", mi precio / hora es: " +
            //    zelemento.PrecioHora +
            //    ", he estado " +
            //    elemento.Tiempo +
            //    "y he generado " + 
            //    elemento.DameCoste());
        }
    }

}
