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

        [TestMethod]
        public void ConstrutorPadraoDeveRetornarSenhaPadrao()
        {
            Senha senha = new();

            Assert.IsTrue(senha.Valor.Length == Senha.TamanhoMinimo);
            Assert.IsTrue(int.TryParse(senha.Valor, out int _));

            Console.WriteLine(senha.Valor);
        }

        [TestMethod]
        [DataRow(8)]
        [DataRow(3)]
        [DataRow(11)]
        public void ConstrutorParametrizadoDeveRetornarSenhaEspecifica(int tamanho)
        {
            Senha senha = new(tamanho);

            Assert.IsTrue(senha.Valor.Length == senha.Tamanho);
            Assert.IsTrue(long.TryParse(senha.Valor, out long _));

            Assert.IsTrue(senha.Valor.Length <= Senha.TamanhoMaximo);
            Assert.IsTrue(senha.Valor.Length >= Senha.TamanhoMinimo);

            Console.WriteLine(senha.Valor);
        }
    }
}