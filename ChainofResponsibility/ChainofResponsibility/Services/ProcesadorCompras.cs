using ChainofResponsibility.Data.Entities.Interfaces;
using ChainofResponsibility.Services.Interfaces;
using System;

namespace ChainofResponsibility.Services
{
    public class ProcesadorCompras
    {
        private readonly IConfiguradorAutorizador ConfiguradorAutorizador;
        public ProcesadorCompras(IConfiguradorAutorizador _configuradorAutorizador)
        {
            this.ConfiguradorAutorizador = _configuradorAutorizador ?? throw new ArgumentNullException(nameof(_configuradorAutorizador));
        }
       
        public void ProcesarCompra(ICompraDTO _compraDTO)
        {
            IAutorizadorCompra autorizadorCompra = ConfiguradorAutorizador.ConfigurarAutorizadoresCompra();
            autorizadorCompra.ProcesarCompra(_compraDTO);
        }
    }
}
