using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Loja.Dominio;
using System.Data.Entity;

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


        //Conceito LazyLOAD Desligado - Ganha em produtividade e perde em performance
        [TestMethod]
        public void LazyLoadDesligado()
        {
            var produto = db.Produtos.SingleOrDefault(p => p.Id==2);

            Assert.IsNull(produto.Categoria);
        }

        [TestMethod]
        public void IncludeTeste()
        {
            var produto = db.Produtos.Include(p => p.Categoria)
                .SingleOrDefault(p => p.Id == 2);

            Console.WriteLine(produto.Categoria.Nome);
        }

        [TestMethod]
        [DataRow(100)]
        public void QueryableTeste(int estoque)
        {
            var query = db.Produtos.Where(p => p.Preco > 10);

            if (estoque > 0)
            {
                query = query.Where(p => p.Estoque >= estoque);
            }

            query.OrderBy(p => p.Preco);

            var primeiro = query.FirstOrDefault();
            var unico = query.SingleOrDefault();
            var todos = query.ToList();
            var ultimo = query.AsEnumerable().LastOrDefault();



        }
    }
}

