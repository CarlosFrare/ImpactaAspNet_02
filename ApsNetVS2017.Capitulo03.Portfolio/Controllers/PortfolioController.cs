using ApsNetVS2017.Capitulo03.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApsNetVS2017.Capitulo03.Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            const string diretorioimagens = "/Content/Imagens/Portfolio";

            var caminhos = Directory.EnumerateFiles(Server.MapPath(diretorioimagens));

            var viewModel = new PortfolioViewModel();


            foreach (var caminho in caminhos)
            {
                viewModel.CaminhosImagens.Add($"{diretorioimagens}/{Path.GetFileName(caminho)}");
            }

            return View(viewModel);
        }
    }
}