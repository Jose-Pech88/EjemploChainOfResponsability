using ChainofResponsibility.Data.Entities.Interfaces;

namespace ChainofResponsibility.Data.Entities
{
    public class CompraDTO : ICompraDTO
    {
        public string cConcepto { set; get; }
        public double dMonto { set; get; }
    }
}
