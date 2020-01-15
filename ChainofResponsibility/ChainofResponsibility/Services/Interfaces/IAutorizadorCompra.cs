using ChainofResponsibility.Data.Entities.Interfaces;

namespace ChainofResponsibility.Services.Interfaces
{
    public interface IAutorizadorCompra
    {
        IAutorizadorCompra SiguienteNivel(IAutorizadorCompra _iAutorizadorCompra);
        void ProcesarCompra(ICompraDTO _compraDTO);
    }
}
