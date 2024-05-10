using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedirDiametroSuperficie.Superficies
{
    public class Cuadrado
    {
        public IVisionable Visor { get; set; }
        public Cuadrado(int v)
        {
        }

        public Cuadrado()
        {
        }

        public int Lado { get; set; }
        public int DameSuperficie()
        {
            return (int)(Math.PI * Lado * Lado);
        }
        public override string? ToString()
        {
            return Visor.DameCadena((IMedible)this);
        }
    }
}
