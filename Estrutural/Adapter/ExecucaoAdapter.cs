namespace DesignPatterns.Estrutural.Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMaster()));
            pagamentoLogCustom.RealizarTransacao();
        }
    }
}