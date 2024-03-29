namespace DesignPatterns.Estrutural.Adapter
{
    // Client
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            _logger.Log("Transacão realizada");
        }
    }
}