using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedirDiametroSuperficie.Superficies
{
    public  class Factoria
    {
        public IMedible dameElemento(EnunTipos tipo, int valor)
        {
            switch (tipo)
            {
                case (int)EnumTipos.Cuadrado: return new Cuadrado() { Lado = 4 };
                case (int)EnumTipos.Circulo: return new Circulo() { Radio = 5  };
                //case (int)EnumTipos.Patinete: return new Patinete() { Identificador = id, PrecioHora = 1, Tiempo = Tiempo };
                default: return null;
            }
        }
    }
}
