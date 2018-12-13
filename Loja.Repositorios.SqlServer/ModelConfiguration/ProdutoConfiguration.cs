using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorios.SqlServer.ModelConfiguration
{
    internal class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            //coloca a precisao do campo
            Property(p => p.Preco)
                .HasPrecision(9,2);

            //equivale a not null
            HasRequired(p => p.Categoria);

            //equivale validar a integridade referencial
            HasOptional(p => p.Imagem)
                .WithRequired(pi => pi.Produto)
                .WillCascadeOnDelete(true);
                
         }

    }
}