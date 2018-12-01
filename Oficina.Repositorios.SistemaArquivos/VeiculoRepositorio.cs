using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Configuration.ConfigurationManager;

namespace Oficina.Repositorios.SistemaArquivos
{

    public class VeiculoRepositorio
    {
        //o valor dessa variavel so pode ser incluida 
        //dentro do metodo CONSTRUTOR
        private readonly string caminhoArquivo;

        private XDocument arquivoXML;

        //METODO CONSTUTOR
        public VeiculoRepositorio()
        {
            caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppSettings["caminhoArquivoVeiculo"]);
        }

        //gravar os registros em um arquivo XML
        
        // public void Inserir (Veiculo veiculo)

        public void Inserir<T> (T veiculo) where T: Veiculo
        {
            arquivoXML = XDocument.Load(caminhoArquivo);

            var registro = new StringWriter();

            new XmlSerializer(typeof(T)).Serialize(registro, veiculo);

            arquivoXML.Root.Add(XElement.Parse(registro.ToString()));

            arquivoXML.Save(caminhoArquivo);

        }

    }
}
