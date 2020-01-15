using ChainofResponsibility.Data.Entities.Interfaces;
using System;

namespace ChainofResponsibility.Services
{
    public class ValidadorDirector : AutorizadorCompra
    {
        public override void ProcesarCompra(ICompraDTO _compraDTO)
        {
            if (_compraDTO.dMonto > 15000 && _compraDTO.dMonto <= 50000)
            {
                Console.WriteLine(string.Format("Compras de {0} 'Autorizada' por el Director.", _compraDTO.cConcepto));
            }
            else
            {
                Console.WriteLine(string.Format("Solicitud de Compras de {0} 'Denegada'.", _compraDTO.cConcepto));
            }
        }
    }
}
