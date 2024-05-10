using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public interface IFactoryAlquilable
    {
        IAlquilable dameElemento(int tipo, string id, double Tiempo);
    }
}
