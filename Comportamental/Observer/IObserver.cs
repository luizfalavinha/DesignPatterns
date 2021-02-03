namespace Design_Patterns.Comportamental.Observer
{
    // Observer
    public interface IObserver
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
