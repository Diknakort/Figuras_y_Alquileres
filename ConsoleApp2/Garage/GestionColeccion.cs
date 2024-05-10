using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Garage
{
    public class GestionColeccion
    {
        private double total;
        private List<IAlquilable> alquileres = new();
        // si lo sumamos nosotros
        void Add(IAlquilable elemento)
        {
            this.alquileres.Add(elemento);

            this.total += elemento.DameCoste();
        }
        // si la colección ya está hecha
        double DameTotal()
        {
            Parallel.ForEach(alquileres, number =>
            {
                total += number.DameCoste();
            });
            return total;
        }


    }
}