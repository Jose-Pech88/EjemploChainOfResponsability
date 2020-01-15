using ChainofResponsibility.Data.Entities.Interfaces;
using ChainofResponsibility.Services.Interfaces;

namespace ChainofResponsibility.Services
{
    public abstract class AutorizadorCompra : IAutorizadorCompra
    {
        private IAutorizadorCompra _nextHandler;
        public IAutorizadorCompra SiguienteNivel(IAutorizadorCompra _iAutorizadorCompra)
        {
            this._nextHandler = _iAutorizadorCompra;

            return _nextHandler;
        }

        public virtual void ProcesarCompra(ICompraDTO _compraDTO)
        {
            if (this._nextHandler != null)
            {
                 this._nextHandler.ProcesarCompra(_compraDTO);
            }            
        }
    }
}
