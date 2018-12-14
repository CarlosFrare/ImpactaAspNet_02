using System;
using System.Collections.Generic;
using System.Data.Entity;
using Loja.Dominio;

namespace Loja.Repositorios.SqlServer
{
    internal class LojaDbInitializer : DropCreateDatabaseIfModelChanges<LojaDbContext>
    {
        protected override void Seed(LojaDbContext context)
        {


            context.Produtos.AddRange(ObterProdutos());
            context.SaveChanges();
        }

        private IEnumerable<Produto> ObterProdutos()
        {
            var produto = new Produto();

            produto.Categoria = new Categoria { Nome = "Perfumaria" };
            produto.Nome = "Barbeador";
            produto.Estoque = 105;
            produto.Preco = 59.99m;

            var produto2 = new Produto();

            produto2.Categoria = new Categoria { Nome = "Papelaria" };
            produto2.Nome = "Livros C#";
            produto2.Estoque = 2544;
            produto2.Preco = 4875.96m;


            return new List<Produto> {produto, produto2 }; 
        }
    }
}