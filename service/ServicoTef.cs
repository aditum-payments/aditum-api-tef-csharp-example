using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using example_csharp_api_tef.entities;
using example_csharp_api_tef.service.util;
using Newtonsoft.Json;

namespace example.servico
{
    class ServicoTEF
    {
        private const string SERVICE = "https://localhost:4090/v1/";

        public static void Payment(Charge charge)
        {

            StringContent data = Mapper<Charge>.Convert(charge);

            HttpClient client = new HttpClient();

            data.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            client.DefaultRequestHeaders.Add("Authorization", "mk_lGF9Pu7rYkEmn7gEEI1pA");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, SERVICE + "charge/authorization");
            request.Content = data;

            Task task = client.SendAsync(request)
                .ContinueWith(responseTask =>
                {
                    Console.WriteLine("Response: {0}", responseTask.Result);
                });
        }

        internal static void Init(InitRequest initRequest)
        {

            StringContent data = Mapper<InitRequest>.Convert(initRequest);

            HttpClient client = new HttpClient();

            data.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            client.DefaultRequestHeaders.Add("Authorization", "mk_lGF9Pu7rYkEmn7gEEI1pA");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, SERVICE + "pinpad/init");
            request.Content = data;

            Task task = client.SendAsync(request)
                .ContinueWith(responseTask =>
                {
                    Console.WriteLine("Response: {0}", responseTask.Result);
                });
        }

        internal static async Task ConfirmAsync(string nsu)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "mk_lGF9Pu7rYkEmn7gEEI1pA");

                string serviceUrl = SERVICE + "charge/confirmation?nsu=" + nsu;

                using (HttpResponseMessage response = await client.GetAsync(serviceUrl))
                {
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("Response: {0}", responseBody);
                }
            }
        }


    }
}