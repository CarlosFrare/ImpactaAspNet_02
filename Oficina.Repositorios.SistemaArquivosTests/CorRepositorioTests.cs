using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        CorRepositorio CorRepositorioSel = new CorRepositorio();


        [TestMethod()]
        public void SelecionarTest()
        {
            var cores = CorRepositorioSel.Selecionar();

            foreach (var cor in cores)
            {
                Console.WriteLine($"{cor.Id}: {cor.Nome}");
            }

            //Assert.Fail();
        }

        [TestMethod()]
        public void SelecionarPorId()
        {
            var cor = CorRepositorioSel.Selecionar(2);
            Assert.IsTrue(cor.Nome == "Azul");

            //testando o parametro NULL na classe
            cor = CorRepositorioSel.Selecionar(0);
            Assert.IsNull(cor);
        }
    }
}