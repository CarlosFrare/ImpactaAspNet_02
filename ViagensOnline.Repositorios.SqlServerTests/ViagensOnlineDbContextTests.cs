using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViagensOnline.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagensOnline.Dominio;

namespace ViagensOnline.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class ViagensOnlineDbContextTests
    {
        private readonly ViagensOnlineDbContext db = new ViagensOnlineDbContext();

        [TestMethod()]
        public void InserirTest()
        {
            var destino = new Destino();

            destino.Cidade = "Sao Paulo";
            destino.Nome = "Carlos";
            destino.NomeImagem = "paulista.png";
            destino.Pais = "Brasil";

            db.Destinos.Add(destino);

            db.SaveChanges();
        }



    }
}