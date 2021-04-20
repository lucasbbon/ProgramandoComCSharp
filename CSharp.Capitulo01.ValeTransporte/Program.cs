using System;

namespace CSharp.Capitulo01.ValeTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write($"Informe o sálario do {nome}: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"Informe o valor gasto com transporte do {nome}: ");
            decimal gasto = Convert.ToDecimal(Console.ReadLine());

            decimal desconto = salario * 6 / 100;
            decimal descontoVT = gasto > desconto ? desconto : gasto;

            string resultado = $"\nFuncionário: {nome}" +
                $"\nSálario: {salario}" +
                $"\nGasto com transporte: {gasto}" +
                $"\nDesconto VT: {descontoVT}";

            Console.WriteLine(resultado);
            Console.WriteLine("\nPressione enter para reiniciar o programa ou ESC para sair.");

            ConsoleKeyInfo comando = Console.ReadKey();

          
            if (comando.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                //Main(args);
                goto Inicio;
            }
        }
    }
}
