using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorios.SqlServer.ModelConfiguration
{
    internal class ProdutoImagemConfiguration : EntityTypeConfiguration<ProdutoImagem>
    {
        public ProdutoImagemConfiguration()
        {

            //ToTable("tabela nome_nome")
            HasKey(pi => pi.ProdutoId);

            //Mudar o nome da cha
            Property(pi => pi.ProdutoId)
                .HasColumnName("Produto_Id");

            Property(c => c.ContentType)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}