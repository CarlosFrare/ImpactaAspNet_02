using ApsNetVS2017.Capitulo03.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApsNetVS2017.Capitulo03.Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.MessageMM = "Entrar em contato";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ConatoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var stringConexao = ConfigurationManager.ConnectionStrings["PortfolioSqlServer"].ConnectionString;

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string instrucao = @"
                INSERT INTO [dbo].[Contato]
                    ([Nome]
                    ,[Email]
                    ,[Mensagem])
                    VALUES
                    (@Nome
                    ,@Email
                    ,@Mensagem)";

                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", viewModel.Nome);
                    comando.Parameters.AddWithValue("@Email", viewModel.Email);
                    comando.Parameters.AddWithValue("@Mensagem", viewModel.Mensagem);

                    comando.ExecuteNonQuery();
                }
 
                // nao precisa do comando abaixo pq o "using" ja fecha a conexao no final do bloco de codigo
                //conexao.Close();
            }

            ModelState.Clear();

            return View();
        }

    }
}