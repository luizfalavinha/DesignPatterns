namespace Design_Patterns.AbstractFactory.ConcreteFactory
{
    //ConcreteFactory2
    public class Samsung : ICelular
    {
        public INormalTelefone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartphone BuscarSmartphone()
        {
            return new SamsungGalaxy();
        }
    }
}
