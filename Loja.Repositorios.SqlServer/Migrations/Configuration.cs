namespace Loja.Repositorios.SqlServer.Migrations
{
    using Loja.Dominio;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Loja.Repositorios.SqlServer.LojaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Loja.Repositorios.SqlServer.LojaDbContext";
        }

        protected override void Seed(LojaDbContext context)
        {
            if (!context.Produtos.Any())
            {
                context.Produtos.AddRange(ObterProdutos());
                context.SaveChanges();
            }
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


            return new List<Produto> { produto, produto2 };
        }
    }
}
