namespace Design_Patterns.AbstractFactory
{
    // Abstract Factory
    public interface ICelular
    {
        ISmartphone BuscarSmartphone();
        INormalTelefone BuscarNormalPhone();
    }
}
