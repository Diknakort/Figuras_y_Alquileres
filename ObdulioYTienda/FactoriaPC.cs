namespace ObdulioYTienda
{
    public class FactoriaPC : IFactoriaVendible
    {
        //public IValidador Validador { get; set; }
        public IVendible DameOrdenador(TipoOrdenador tipoOrdenador, int precio, int garantia)
        {
            //IVendible vendible = null;
            switch (tipoOrdenador)
            {

                case TipoOrdenador.Lentorro: new OrdenadorLentorro(); break;
                case TipoOrdenador.Gamer: new OrdenadorGamer(); break;

                case TipoOrdenador.Normal: new OrdenadorNormal(); break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}


