using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedirDiametroSuperficie.Superficies
{
    public interface IFactoriaMedibles
    {
        IMedible dameElemento(int tipo, int valor);
    }
   
}
