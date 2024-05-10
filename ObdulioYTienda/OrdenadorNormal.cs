using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class OrdenadorNormal : IVendible
    {
        public int Precio { get; set; } = 300;
        public int Garantia { get; set; } = 3;

        public double TiempoMedio()
        {
            return Precio / Garantia;
        }
        public override string ToString()
        {
            return $"Ordenador 'Normal' tiene un precio de: {Precio}, y una garantía de: {Garantia}, el coeficiente de garantía (tiempoMedio) es: {TiempoMedio()}";
        }
    }
}