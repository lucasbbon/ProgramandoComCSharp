using System;

namespace Fintech.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public Sexo Sexo { get; set; }
        public Endereco Endereco { get; set; }
        public ContaCorrente ContaCorrente { get; set; }

    }
}