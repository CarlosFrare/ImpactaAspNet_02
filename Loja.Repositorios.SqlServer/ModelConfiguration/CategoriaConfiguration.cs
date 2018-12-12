using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;


namespace Loja.Repositorios.SqlServer.ModelConfiguration
{
    class CategoriaConfiguration: EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
        }
    }
}