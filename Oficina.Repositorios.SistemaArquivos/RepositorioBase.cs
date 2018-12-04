using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Configuration.ConfigurationManager;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class RepositorioBase
    {
        protected string ObterCaminhoCompleto(string caminho)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppSettings[caminho]);
         }
    }
}