using ChainofResponsibility.Data.Entities.Interfaces;
using System;

namespace ChainofResponsibility.Services
{
    public class ValidadorCoordinador : AutorizadorCompra
    {
        public override void ProcesarCompra(ICompraDTO _compraDTO)
        {
            if (_compraDTO.dMonto <= 5000)
            {
                Console.WriteLine(string.Format(@"Compras de {0} 'Autorizada' por el Coordinador.", _compraDTO.cConcepto));
            }
            else
            {
                base.ProcesarCompra(_compraDTO);
            }            
        }
    }
}
