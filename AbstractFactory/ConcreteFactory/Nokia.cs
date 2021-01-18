namespace Design_Patterns.AbstractFactory.ConcreteFactory
{
    //ConcreteFactory1
    public class Nokia : ICelular
    {
        public INormalTelefone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartphone BuscarSmartphone()
        {
            return new NokiaPixel();
        }
    }
}
