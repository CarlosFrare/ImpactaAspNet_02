using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Loja.Dominio;

namespace Loja.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class LojaDbContextTests
    {
        private readonly LojaDbContext db = new LojaDbContext();

        public LojaDbContextTests()
        {
            db.Database.Log = LogarQuery;
        }

        private void LogarQuery(string query)
        {
            Debug.WriteLine(query);
        }

        [TestMethod()]
        public void InseritCatrgoriaTest()
        {
            var papelaria = new Categoria();
            papelaria.Nome = "Vestuário";

            db.Categorias.Add(papelaria);
            db.SaveChanges();
        }


        [TestMethod]
        public void InserirProdutoTest()
        {
            var produto = new Produto();
            
            produto.Categoria = db.Categorias.Find(2);
            produto.Nome = "Camisa";
            produto.Estoque = 3;
            produto.Preco = 69.99m;

            db.Produtos.Add(produto);
            db.SaveChanges();

        }

        [TestMethod]
        public void InserirProdutoComNovaCategoria()
        {
            var produto = new Produto();

            produto.Categoria = new Categoria { Nome = "Perfumaria" };
            produto.Nome = "Barbeador";
            produto.Estoque = 10;
            produto.Preco = 35.96m;

            db.Produtos.Add(produto);
            db.SaveChanges();

        }

        [TestMethod]
        public void EditarProdutoTeste()
        {
            var produto = db.Produtos.Where(p => p.Nome.Contains("Cami"))
                .FirstOrDefault();

            produto.Preco = 65.78m;
            produto.Nome = "Paleto";

            db.SaveChanges();
        }

        [TestMethod]
        public void ExcluirProdutoTeste()
        {
            var produto = db.Produtos.Where(p => p.Categoria.Nome == "Perfumaria")
                .ToList();

            db.Produtos.RemoveRange(produto);
            db.SaveChanges();

            Assert.IsFalse(db.Produtos.Any(p => p.Categoria.Nome == "Perfumaria"));
        }

    }
}

