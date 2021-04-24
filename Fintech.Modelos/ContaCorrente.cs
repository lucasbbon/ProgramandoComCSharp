using System;

namespace Fintech.Modelos
{
    public class ContaCorrente
    {
        public Cliente Cliente { get; set; }
        public Agencia Agencia { get; set; }
        public int Conta { get; set; }
        public string Digito { get; set; }
        public decimal Saldo { get; set; }

        public void EfetuarOperacao(decimal valor, Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Deposito:
                    Saldo += valor;
                    break;
                case Operacao.Saque:
                    Saldo -= valor;
                    break;
            }
        }
    }
}
