using ChainofResponsibility.Services.Interfaces;

namespace ChainofResponsibility.Services
{
    public class ConfiguradorAutorizador : IConfiguradorAutorizador
    {
        public IAutorizadorCompra ConfigurarAutorizadoresCompra()
        {
            var ValidadorCoordinador = new ValidadorCoordinador();
            var ValidadorGerente = new ValidadorGerente();
            var ValidadorSubdirector = new ValidadorSubdirector();
            var ValidadorDirector = new ValidadorDirector();

            ValidadorCoordinador.SiguienteNivel(ValidadorGerente).SiguienteNivel(ValidadorSubdirector).SiguienteNivel(ValidadorDirector);
            return ValidadorCoordinador;
        }
    }
}
