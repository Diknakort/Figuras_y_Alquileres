using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public interface IAlquilable
    {
        string Identificador { get; set; }
        double PrecioHora { get; set; }
        double Tiempo { get; set; }
        double DameCoste();

    }
}
