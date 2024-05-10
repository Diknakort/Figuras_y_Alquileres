using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public class Patinete : IAlquilable
    {
        public string Identificador { get ; set ; }
        public double PrecioHora { get ; set ; }
        public double Tiempo { get ; set ; }

        public double DameCoste()
        {
            return PrecioHora * Tiempo;
        }
    }
}
