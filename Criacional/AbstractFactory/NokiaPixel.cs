namespace Design_Patterns.AbstractFactory
{
    // Produto A1
    public class NokiaPixel : ISmartphone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Nokia Pixel\nRAM: 4GB\nCamera: 12MP\n";
        }
    }
}
