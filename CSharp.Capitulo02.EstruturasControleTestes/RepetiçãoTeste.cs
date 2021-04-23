using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp.Capitulo02.EstruturasControleTestes
{
    [TestClass]
    public class Repeti��oTeste
    {
        [TestMethod]
        public void TabuadaTeste()
        {
            for(var i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine(new string('-', 50));
            }
        }

        [TestMethod]
        public void DemonstrarEstruturaForTeste()
        {
            int i = 1;
            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }

            /*
             for(1. Inicializa��o; 2. Condi��o; 4. P�s-Execu��o)
             {
               3. Execu��o;
             }
             */ 
        }

        [TestMethod]
        public void ForApenasComCondi��oTeste()
        {
            var i = 1;
            for (; i < 3;)
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                    continue;
                
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                    break;

                Console.WriteLine(i);
            }
        }
    }
}
