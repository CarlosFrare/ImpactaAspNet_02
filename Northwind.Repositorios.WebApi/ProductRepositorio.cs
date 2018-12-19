using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repositorios.WebApi
{
    public class ProductRepositorio
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly string url = "http://localhost:49928/api/products";

        public async Task<ProdctViewModel> Post(ProdctViewModel prodct)
        {
            using (var resposta = await httpClient.PostAsJsonAsync(url, prodct))
            {
                resposta.EnsureSuccessStatusCode();

                return await resposta.Content.ReadAsAsync<ProdctViewModel>();
            }

        }

        public async Task Put(ProdctViewModel prodct)
        {
            using (var resposta = await httpClient.PutAsJsonAsync($"{url}/{prodct.productID}", prodct))
            {
                resposta.EnsureSuccessStatusCode();

            }

        }

        public async Task<List<ProdctViewModel>> Get()
        {
            using (var resposta = await httpClient.GetAsync(url))
            {
                resposta.EnsureSuccessStatusCode();

                return await resposta.Content.ReadAsAsync<List<ProdctViewModel>>();
            }

        }

        public async Task<ProdctViewModel> Get(int Id)
        {
            using (var resposta = await httpClient.GetAsync($"{url}/{Id}"))
            {
                resposta.EnsureSuccessStatusCode();

                return await resposta.Content.ReadAsAsync<ProdctViewModel>();
            }

        }

        public async Task Delete(int Id)
        {
            using (var resposta = await httpClient.DeleteAsync($"{url}/{Id}"))
            {
                resposta.EnsureSuccessStatusCode();
            }

        }


    }
}
