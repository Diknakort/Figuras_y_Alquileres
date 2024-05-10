using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedirDiametroSuperficie.Superficies
{
    public interface IMedible
    {
        int numero {  get; set; }
        int DameSuperficie();
        int DamePerimetro();
    }
    
}
