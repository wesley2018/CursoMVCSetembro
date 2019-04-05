using System;
using System.Linq;
using EP.CursoMvc.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EP.CursoMvc.Domain.Tests.Entity
{
    [TestClass]
    public class ClienteTest
    {
        //Boneco
        public Cliente Cliente { get; set; }
        

        [TestMethod]
        public void ClienteConsistente_Valid_True()
        {
            Cliente = new Cliente
            {
                CPF = "01961977087",
                DataNascimento = new DateTime(1982, 01, 01),
                Email = "cliente@cliente.com.br"
            };

            Assert.IsTrue(Cliente.IsValid());
        }
        [TestMethod]
        public void ClienteConsistente_Valid_False()
        {
            Cliente = new Cliente
            {
                CPF = "01961977086",
                DataNascimento = new DateTime(2018, 01, 01),
                Email = "cliente2cliente.com.br"
            };

            Assert.IsFalse(Cliente.IsValid());
            Assert.IsTrue(Cliente.ValidationResult.Erros.Any(e => e.Message == "Cliente informou um CPF inválido."));
            Assert.IsTrue(Cliente.ValidationResult.Erros.Any(e => e.Message == "Cliente informou um e-mail inválido."));
            Assert.IsTrue(Cliente.ValidationResult.Erros.Any(e => e.Message == "Cliente não tem maioridade para cadastro."));

        }
    }
}
