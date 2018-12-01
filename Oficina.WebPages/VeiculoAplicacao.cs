using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {
        private readonly MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        private readonly CorRepositorio corRepositorio = new CorRepositorio();
        private readonly ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        private readonly VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();

        // metodo construtor : atalho snipet ctor 
        public VeiculoAplicacao()
        {

            //gatilho que dispara o "new" e carrega os combosbox
            PorpularControles();
        }

        public List<Marca> Marcas { get; private set; }
        public string MarcaSelecionada { get; set; }
        public List<Cor> Cores { get; private set; }
        public List<Combustivel> Combustiveis { get; private set; }
        public List<Cambio> Cambios { get; private set; }
        public List<Modelo> Modelos { get; private set; } = new List<Modelo>();

        private void PorpularControles()
        {
            Marcas = marcaRepositorio.Selecionar();
            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"];

            if (!string.IsNullOrEmpty(MarcaSelecionada))
            {
                Modelos = modeloRepositorio.SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));
            }

            Cores = corRepositorio.Selecionar();

            //chamando os enumeradors e gerar a propriedades
            Combustiveis = Enum.GetValues(typeof(Combustivel)).Cast<Combustivel>().ToList();
            Cambios = Enum.GetValues(typeof(Cambio)).Cast<Cambio>().ToList();

            }

        public void Inserir()
        {
            var veiculo = new VeiculoPasseio();
            var formulario = HttpContext.Current.Request.Form;

            veiculo.Ano = Convert.ToInt32(formulario["ano"]);
            veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]);
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]);
            veiculo.Cor = corRepositorio.Selecionar(Convert.ToInt32(formulario["Cor"]));
            veiculo.Modelo = modeloRepositorio.Selecionar(Convert.ToInt32(formulario["modelo"]));
            veiculo.Observacao = formulario["observacao"];
            veiculo.Placa = formulario["PUW-1514"];
            

            veiculoRepositorio.Inserir(veiculo);
        }


    }

}