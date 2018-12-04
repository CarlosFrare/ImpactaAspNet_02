using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio : RepositorioBase
    {
        /// <summary>
        /// Medtodo para chamar o arquivo XML
        /// </summary>

        //ToDo: Implementar método de extensão.

        /*         
        private string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                AppSettings["caminhoArquivoCor"]);

        */

        private string caminhoArquivo;

        public CorRepositorio()
        {
            caminhoArquivo = ObterCaminhoCompleto("caminhoArquivoCor");
        }


        //metodo selecionar gerar lista no DropDowlist / ou Combobox
        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

            //Duas maneiras   
            //foreach (var linha in File.ReadAllLines(@"Dados\Cor.txt"))
            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
            }
            return cores;
        }

        //metodo selecionar gerar lista no DropDowlist / ou Combobox com parametro ID
        public Cor Selecionar(int id)
        {
            
            //instancia da classe cor
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var linhaId = linha.Substring(0, 5);

                if (Convert.ToInt32(linhaId) == id)
                {
                    cor = new Cor();
                    cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                    cor.Nome = linha.Substring(5);
                    break;
                }
                
            }

            return cor;
        }
    }
}
