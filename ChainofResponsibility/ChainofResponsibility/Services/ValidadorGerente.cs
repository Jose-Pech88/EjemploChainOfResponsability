using ChainofResponsibility.Data.Entities.Interfaces;
using System;

namespace ChainofResponsibility.Services
{
    public class ValidadorGerente : AutorizadorCompra
    {
        public override void ProcesarCompra(ICompraDTO _compraDTO)
        {
            if (_compraDTO.dMonto > 5000 && _compraDTO.dMonto<=10000)
            {
                Console.WriteLine(string.Format("Compras de {0} 'Autorizada' por el Gerente.", _compraDTO.cConcepto));
            }
            else
            {
                
                base.ProcesarCompra(_compraDTO);
            }
        }
    }
}
