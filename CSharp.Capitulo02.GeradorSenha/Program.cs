﻿using System;

namespace CSharp.Capitulo02.GeradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDigitos;            

            do
            {
                Console.Write("Informe a quantidade de dígitos da senha (entre 4 e 10): ");
                quantidadeDigitos = ObterQuantidadeDigitos();

            } while (quantidadeDigitos == 0);

            var senha = new Senha(quantidadeDigitos);

            Console.WriteLine($"Senha gerada: {senha.Valor}");
            Environment.Exit(0);
        }

        private static int ObterQuantidadeDigitos()
        {
            //var quantidadeDigitos = Convert.ToInt32(Console.ReadLine());

            int.TryParse(Console.ReadLine(), out int quantidadeDigitos);

            //if (quantidadeDigitos < 4 || quantidadeDigitos > 10 || quantidadeDigitos % 2 != 0)
            if (quantidadeDigitos is (< 4 or > 10) || quantidadeDigitos % 2 != 0)
            {
                Console.WriteLine($"A quantidade de dígitos {quantidadeDigitos} é inválida.");
                quantidadeDigitos = 0;
            }

            return quantidadeDigitos;
        }
    }
}
