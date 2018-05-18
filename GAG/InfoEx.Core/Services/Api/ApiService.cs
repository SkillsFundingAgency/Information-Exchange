using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GAG.Core.Domain.Gag;
using Newtonsoft.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace GAG.Core.Services.Api
{
    public class ApiService : IApiService
    {
        public const string API_URL = "http://calculate-funding-service.azurewebsites.net/api/";

        public ProviderResultSummary GetFundingTotalsForProvider(string ukPrn, DateTime periodDateTime)
        {
            //var period = GetPeriodByDate(DateTime.Now);
            //string urlParams = $"providers/{ukPrn}/periods/{period}/summary";

            //HttpClient client = new HttpClient {BaseAddress = new Uri(API_URL)};

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = client.GetAsync(urlParams).Result;
            //string test = string.Empty;


            //return JsonConvert.DeserializeObject<ProviderResultSummary>(response.ToString());

            return null;
        }

        public List<T> GetRequest<T>(string urlParams)
        {
            //string urlParams = "periods";
            string responseString = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(urlParams).Result;

                if (response.IsSuccessStatusCode)
                {
                    responseString = response.Content.ReadAsStringAsync().Result;
                }
            }

            return JsonConvert.DeserializeObject<List<T>>(responseString);
        }

        public T GetRequestSingle<T>(string urlParams)
        {
            //string urlParams = "periods";
            string responseString = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(urlParams).Result;

                if (response.IsSuccessStatusCode)
                {
                    responseString = response.Content.ReadAsStringAsync().Result;
                }
            }

            return JsonConvert.DeserializeObject<T>(responseString);

        }
    }
}
