using System;

namespace CSharp.Capitulo02.GeradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Informe a quantidade de dígitos da senha (entre 4 e 10)");
            int quantidadeDigitos;

            do
	        {
                Console.Write("Informe a quantidade de dígitos da senha (entre 4 e 10)");
                quantidadeDigitos = ObterQuantidadedeDigitos();
	        } while (quantidadeDigitos == 0);

            string senha = "";
            Random random = new Random();

            for (int i = 0; i < quantidadeDigitos; i++)
                senha += random.Next(0, 9);

            Console.WriteLine($"Senha gerada: {senha}");
            Environment.Exit(0);
        }

        private static Int32 ObterQuantidadedeDigitos()
        {
            int.TryParse(Console.ReadLine(), out int quantidadeDigitos);

            if (quantidadeDigitos is (< 4 or > 10) || quantidadeDigitos % 2 != 0)
            {
                Console.WriteLine($"A quantidade de dígitos {quantidadeDigitos} é inválida.");
                quantidadeDigitos = 0;
            }

            return quantidadeDigitos;
        }
    }
}
