using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {

            var veiculo = new VeiculoPasseio();

            //veiculo.Id = 1;
            veiculo.Placa = "PUW-1514";
            veiculo.Ano = 2014;
            veiculo.Observacao = "teste";
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Modelo = new ModeloRepositorio().Selecionar(4);
            veiculo.Cor = new CorRepositorio().Selecionar(2);
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Cambio = Cambio.Automatico;

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}