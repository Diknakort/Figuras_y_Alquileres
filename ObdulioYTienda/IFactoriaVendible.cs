namespace ObdulioYTienda
{
    public interface IFactoriaVendible
    {
        IVendible DameOrdenador(TipoOrdenador tipoOrdenador, int precio, int garantia);
    }
}