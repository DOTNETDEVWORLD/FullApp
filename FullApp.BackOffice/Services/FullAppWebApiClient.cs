using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.BackOffice.Services
{
    public class FullAppWebApiClient
    {
        private HttpClient client = new HttpClient();

        public FullAppWebApiClient()
        {
            Initialize();
        }

        public void Initialize()
        {
            client.BaseAddress = new Uri("http://localhost:53465/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        } 
        
        
        public async Task<IEnumerable<Product>> GetProducts()
        {
            IEnumerable<Product> products = null;
            HttpResponseMessage response = await client.GetAsync("Api/Product");
            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadAsAsync<IEnumerable<Product>>();
            }
            return products;
        }        
    }
}
