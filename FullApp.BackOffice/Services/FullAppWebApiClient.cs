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

        public void Initialize()
        {
            client.BaseAddress = new Uri("http://localhost:55268/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        } 
    }
}
