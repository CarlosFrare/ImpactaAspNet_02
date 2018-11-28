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
    public class MarcaRepositorioTests
    {
        MarcaRepositorio MarcaRepositorioSel = new MarcaRepositorio();


        [TestMethod()]
        public void SelecionarTest()
        {
            var marcas = MarcaRepositorioSel.Selecionar();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id}: {marca.Nome}");
            }
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(-1)]
        public void SelecionarPorId(int marcaId)
        {
            var marca = MarcaRepositorioSel.Selecionar(marcaId);


            if (marcaId > 0)
            {
                Assert.AreEqual(marca.Nome, "HYUNDAI");
            }
            else
            {
                //testando o parametro NULL na classe

                Assert.IsNull(marca);
            }


        }
    }
}