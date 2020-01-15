using ChainofResponsibility.Data.Entities;
using ChainofResponsibility.Data.Entities.Interfaces;
using ChainofResponsibility.Services;
using ChainofResponsibility.Services.Interfaces;
using System;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InicializarAplicacion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void InicializarAplicacion()
        {
            // The other part of the client code constructs the actual chain.

            string cCadena = string.Empty;
            do
            {
                Console.Clear();
                ProcesarCompra();                
                cCadena = Console.ReadLine();
            }
            while (cCadena != "S");
        }

        static void ProcesarCompra()
        {
            Console.WriteLine("Capture el concepto de compra");
            var cConcepto = Console.ReadLine();
            double nMonto = -1;
            bool lSalir = false;
            do
            {
                Console.WriteLine("Capture el monto de compra");
                var cMonto = Console.ReadLine();
                if (double.TryParse(cMonto, out nMonto))
                    lSalir = true;
                else
                    Console.WriteLine("Valor Incorrecto.");
            }
            while (!lSalir);

            IConfiguradorAutorizador ConfiguradorAutorizador = new ConfiguradorAutorizador();
            ProcesadorCompras ProcesadorCompras = new ProcesadorCompras(ConfiguradorAutorizador);
            ICompraDTO compraDTO = new CompraDTO { cConcepto = cConcepto, dMonto = nMonto };
            ProcesadorCompras.ProcesarCompra(compraDTO);           
            Console.WriteLine("\r\nPresione cualquier tecla para continuar o Presione S para salir.");            
        }
    }
}
