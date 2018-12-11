using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pessoal.Dominio.Entidades;
using Pessoal.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoal.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class TarefaRepositorioTests
    {
        private readonly TarefaRepositorio repositorio = new TarefaRepositorio();

        [TestMethod()]
        public void InserirTest()
        {
            var tarefa = new Tarefa();

            tarefa.Concluida = false;
            tarefa.Nome = "Lavar Roupa";
            tarefa.Observacoes = "Rapido de novo";
            tarefa.Prioridade = Prioridade.Alta;

            tarefa.Id = repositorio.Inserir(tarefa);

            Assert.AreNotEqual(tarefa.Id, 0);
        }

        [TestMethod()]
        public void AtualizarTest()
        {

            var tarefa = new Tarefa();

            tarefa.Id = 1;
            tarefa.Concluida = true;
            tarefa.Nome = "Limpar o banheiro..";
            tarefa.Observacoes = "Anda logo...";
            tarefa.Prioridade = Prioridade.Media;

            repositorio.Atualizar(tarefa);

        }

        [TestMethod()]
        public void SelecionarTest()
        {

            foreach (var tarefa in repositorio.Selecionar())
            {
                Console.WriteLine($"{tarefa.Id} - {tarefa.Nome} - {tarefa.Observacoes} - {tarefa.Prioridade}");
            }

            //Assert.Fail();
        }

        [TestMethod()]
        public void ExcluirTest()
        {
            var tarefa = new Tarefa();
            tarefa.Id = 1;

            repositorio.Excluir(tarefa.Id);
            
            // ou pode ser assim
            //Assert.IsNull(repositorio.Excluir(1));
        }
    }
}