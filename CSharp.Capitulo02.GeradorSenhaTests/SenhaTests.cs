using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Capitulo02.GeradorSenha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Capitulo02.GeradorSenha.Tests
{
    [TestClass()]
    public class SenhaTests
    {
        [TestMethod()]
        public void GerarSenhaSemParametrosDeveRetornarSenhaPadrao()
        {
            Senha senha = new();
            string valor = senha.GerarSenha();


            Assert.IsTrue(valor.Length == Senha.TamanhoMinimo);
            Assert.IsTrue(int.TryParse(valor, out int _));

            Console.WriteLine(valor);
        }
    }
}