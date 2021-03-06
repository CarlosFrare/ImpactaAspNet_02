﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Configuration.ConfigurationManager;

namespace Oficina.Repositorios.SistemaArquivos

{
    public class MarcaRepositorio
    {

        /// <summary>
        /// Medtodo para chamar o arquivo XML
        /// </summary>
        private string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                AppSettings["caminhoArquivoMarca"]);

        public List<Marca> Selecionar()
        {
            var marcas = new List<Marca>();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                //metodo para ler arquivos txt com demilitador - exemplo pipe: "|" 
                var propriedades = linha.Split('|');
                
                var marca = new Marca();
                marca.Id = Convert.ToInt32(propriedades[0]);
                marca.Nome = propriedades[1];

                marcas.Add(marca);
            }
            return marcas;
        }

        public Marca Selecionar(int id)
        {

            //instancia da classe marca
            Marca marca = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var propriedades = linha.Split('|');

                if (Convert.ToInt32(propriedades[0]) == id)
                {
                    marca = new Marca();
                    marca.Id = Convert.ToInt32(propriedades[0]);
                    marca.Nome = propriedades[1];
                    break;
                }
            }
            return marca;
        }

    }
}
