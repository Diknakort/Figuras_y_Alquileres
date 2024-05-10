using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public class Furgoneta : IAlquilable
    {
        public IVisionable Visor { get; set; }
        public Furgoneta(string identificador, double precioHora, double tiempo)
        {
            Identificador = identificador;
            PrecioHora = precioHora;
            Tiempo = tiempo;
        }

        public string Identificador { get ; set ; }
        public double PrecioHora { get; set; } = 5;
        public double Tiempo { get ; set ; }

        public double DameCoste()
        {
            return PrecioHora * Tiempo;
        }
        public override string? ToString()
        {
            return $"Hola soy una furgoneta con precio/hora: {this.PrecioHora} y un coste de {DameCoste()} ";
        }
    }
}
