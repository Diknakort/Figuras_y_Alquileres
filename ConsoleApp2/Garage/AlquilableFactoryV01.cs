using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public class AlquilableFactoryV01 : IFactoryAlquilable
    {
        public IAlquilable dameElemento(int tipo, string id, double Tiempo)
        {
            switch (tipo)
            {
                case (int)EnumTipos.Coche: return new Coche() { Identificador = id, PrecioHora = 4, Tiempo = Tiempo };
                case (int)EnumTipos.Furgoneta: return new Furgoneta() { Identificador = id, PrecioHora = 5, Tiempo = Tiempo };
                case (int)EnumTipos.Patinete: return new Patinete() { Identificador = id, PrecioHora = 1, Tiempo = Tiempo };
                default: return null;
            }
        }
    }
}