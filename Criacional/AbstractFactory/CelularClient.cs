namespace Design_Patterns.AbstractFactory
{
    class CelularClient
    {
        ISmartphone smartPhone;
        INormalTelefone normalPhone;

        public CelularClient(ICelular celularFactory)
        {
            smartPhone = celularFactory.BuscarSmartphone();
            normalPhone = celularFactory.BuscarNormalPhone();
        }

        public string BuscarSmartphoneModeloDetalhe()
        {
            return smartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalphoneModeloDetalhes()
        {
            return normalPhone.BuscarDetalhesModelo();
        }
    }
}
