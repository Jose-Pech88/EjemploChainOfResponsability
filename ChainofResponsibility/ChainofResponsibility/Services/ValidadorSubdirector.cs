using ChainofResponsibility.Data.Entities.Interfaces;
using System;

namespace ChainofResponsibility.Services
{
    public class ValidadorSubdirector : AutorizadorCompra
    {
        public override void ProcesarCompra(ICompraDTO _compraDTO)
        {
            if (_compraDTO.dMonto > 10000 && _compraDTO.dMonto <= 15000)
            {
                Console.WriteLine(string.Format("Compras de {0} 'Autorizada' por el Subdirector.", _compraDTO.cConcepto));
            }
            else
            {
                base.ProcesarCompra(_compraDTO);
            }
        }
    }
}
