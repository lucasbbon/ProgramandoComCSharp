using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CSharp.Capitulo02.EstruturasControleTestes
{
    [TestClass]
    public class DecisãoTeste
    {
        [TestMethod]
        public void AvaliaçãoFinalReprovado29Teste()
        {
            double notaFinal = 2.9;
            string resultadoFinal = ""; //notaFinal < 3 ? "Reprovado" : notaFInal >= 3 && notaFinal < 5 ? "Recuperação" : "Aprovado";

            if (notaFinal < 3)
            {
                resultadoFinal = "Reprovado";
            }
            else if (notaFinal is >= 3 and < 5)
            {
                resultadoFinal = "Recuperação";
            }
            else
            {
                resultadoFinal = "Aprovado";
            }

            /*switch(notaFinal)
            {
                case < 3:
                    resultadoFinal = "Reprovado";
                    break;
                case >= 3 and < 5:
                    resultadoFinal = "Recuperação";
                    break;
                default:
                    resultadoFinal = "Aprovado";
                    break;
            }*/

            Assert.AreEqual(resultadoFinal, "Reprovado'");

            Console.WriteLine(resultadoFinal);
        }

        [TestMethod]
        public void AvaliaçãoFinalRecuperação3Teste()
        {
            double notaFinal = 3.0;
            string resultadoFinal = "";

            switch (notaFinal)
            {
                case < 3:
                    resultadoFinal = "Reprovado";
                    break;
                case >= 3 and < 5:
                    resultadoFinal = "Recuperação";
                    break;
                default:
                    resultadoFinal = "Aprovado";
                    break;
            }

            Assert.AreEqual(resultadoFinal, "Recuperação");
        }

        [TestMethod]
        public void AvaliaçãoFinalRecuperação49Teste()
        {
            double notaFinal = 4.9;
            string resultadoFinal = notaFinal switch
            {
                < 3 => "Reprovado",
                >= 3 and < 5 => "Recuperação",
                _ => "Aprovado",
            };

            Assert.AreEqual(resultadoFinal, "Recuperação");
        }

        [TestMethod]
        [DataRow(2.9, "Reprovado")]
        [DataRow(3, "Recuperação")]
        [DataRow(4.9, "Recuperação")]
        [DataRow(5, "Aprovado")]
        public void AvaliaçãoFinalTeste(double notaFinal, string resultadoEsperado)
        {
            string resultadoFinal = notaFinal switch
            {
                < 3 => "Reprovado",
                >= 3 and < 5 => "Recuperação",
                _ => "Aprovado",
            };

            Assert.AreEqual(resultadoFinal, resultadoEsperado);
        }
    }
}
