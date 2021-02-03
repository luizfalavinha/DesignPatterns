namespace Design_Patterns.AbstractFactory
{
    // Produto B2
    public class SamsungGuru : INormalTelefone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
