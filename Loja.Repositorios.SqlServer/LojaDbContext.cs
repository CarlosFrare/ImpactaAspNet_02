using Loja.Dominio;
using Loja.Repositorios.SqlServer.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Repositorios.SqlServer
{
    public class LojaDbContext: DbContext
    {
        public LojaDbContext() : base("lojaSqlServer")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //#region serve para agrupar o comando
            /*
             * #region Produto

            #endregion
            */

            modelBuilder.Conventions.Add(new ProdutoConfiguration());
            modelBuilder.Conventions.Add(new CategoriaConfiguration());
            modelBuilder.Conventions.Add(new ClienteConfiguration());
            modelBuilder.Conventions.Add(new PedidoConfiguration());


        }
    }
}
