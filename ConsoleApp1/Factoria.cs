using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Factoria : IFactoriaMedibles
    {




        public IMedible DameFigura(TipoFigura tipoFigura, int valor)
        {
            switch (tipoFigura)
            {
                case TipoFigura.Circulo:
                    return new Circulo(valor) { Radio = valor, Visor = new VisionadorConsola() };
                case TipoFigura.Cuadrado:
                    return new Cuadrado(valor) { Lado = valor, Visor = new VisionadorConsola() };
                    default:
                    throw new NotSupportedException("No existe");
            }
        }
    }
}
