using System;
using System.Collections.Generic;

namespace Design_Patterns.Comportamental.Observer
{

    // Subject
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObserver> _observadores = new List<IObserver>();

        protected Investimento(string simbolo, decimal valor)
        {
            Simbolo = simbolo;
            _valor = valor;
        }

        public string Simbolo { get; }
        public decimal Valor 
        {
            get => _valor;
            set
            {
                if (_valor == value) return;

                _valor = value;
                Notificar();
            } 
        }

        public void Subscribe(IObserver observador)
        {
            _observadores.Add(observador);
            Console.WriteLine($"Notificando que {observador.Nome} está recebendo atualizações de {Simbolo}");
        }

        public void UnSubscribe(IObserver observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} NAO está recebendo atualizações de {Simbolo}");
        }

        private void Notificar()
        {
            foreach (var investor in _observadores)
            {
                investor.Notificar(this);
            }
        }
    }
}
