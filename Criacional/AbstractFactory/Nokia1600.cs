namespace Design_Patterns.AbstractFactory
{
    // Produto B1
    public class Nokia1600 : INormalTelefone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
