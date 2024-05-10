using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedirDiametroSuperficie.Superficies
{
    public class Circulo : IFactoriaMedibles
    {
        public IVisionable Visor { get; set; }
        public int Radio { get; set; }
        public IMedible dameElemento(int tipo, int valor)
        {
            throw new NotImplementedException();
        }
        public Circulo(int radio)
        {
            Radio = radio;
        }
        public Circulo(string v1, int v2, int v3)
        {
        }
        public int DameSuperficie()
        {
            return (int)(Math.PI * Radio * Radio);
        }
        public int DamePerimetro()
        {
            return (int)(2 * Math.PI * Radio);
        }
        public override string? ToString()
        {
            return Visor.DameCadena(this);
        }

    }
}
