using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ColeccionFiguras
    {
        private List<IMedible> figuras = new();
        public void Add(IMedible elemento)
        {
            this.figuras.Add(elemento);
        }
        public int CantidadDeFiguras()
        {
            return figuras.Count;
        }
        public double SuperficieTotal()
        {
            double superficieTotal = 0;
            foreach (var figura in figuras)
            {
                superficieTotal += figura.dameSuperficie();
            }
            return superficieTotal;
        }
        public double PerimetroTotal()
        {
            double perimetroTotal = 0;
            foreach (var figura in figuras)
            {
                perimetroTotal += figura.damePerimetro();
            }
            return perimetroTotal;
        }
        public IMedible FiguraMasPequena()
        {
            if (figuras.Count == 0)
                return null;

            IMedible figuraMasPequena = figuras[0];
            foreach (var figura in figuras)
            {
                if (figura.dameSuperficie() < figuraMasPequena.dameSuperficie())
                {
                    figuraMasPequena = figura;
                }
            }
            return figuraMasPequena;
        }

        public double MediaSuperficie()
        {
            //if (figuras.Count == 0)
            //    return 0;

            //double sumaSuperficies = 0;
            //foreach (var figura in figuras)
            //{
            //    sumaSuperficies += figura.dameSuperficie();
            //}
            //return sumaSuperficies / figuras.Count;
            return SuperficieTotal() / figuras.Count;
        }
        public double MediaPerimetro()
        {
            if (figuras.Count == 0)
                return 0;

            double sumaPerimetros = 0;
            foreach (var figura in figuras)
            {
                sumaPerimetros += figura.damePerimetro();
            }
            return sumaPerimetros / figuras.Count;
        }
    }
}
