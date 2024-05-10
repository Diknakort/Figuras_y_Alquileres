using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    internal class Coche : IAlquilable
    {
        public IVisionable Visor { get; set; }


        public Coche(string identificador, int tiempo)
        {
            Identificador = identificador;
            Tiempo = tiempo;
        }

        public Coche(string identificador, double precioHora, double tiempo)
        {
            Identificador = identificador;
            PrecioHora = precioHora;
            Tiempo = tiempo;
        }

        public string Identificador { get ; set ; }
        public double PrecioHora { get ; set ; }
        public double Tiempo { get ; set ; }

        public double DameCoste()
        {
            return PrecioHora * Tiempo;
        }

        public override string? ToString()
        {
            return Visor.DameCadena(this);
        }
    }
}
