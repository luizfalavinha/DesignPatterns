namespace Design_Patterns.AbstractFactory
{

    // Produto A2
    public class SamsungGalaxy : ISmartphone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Samsung Galaxy\nRAM: 4GB\nCamera: 16MP\n";
        }
    }
}
