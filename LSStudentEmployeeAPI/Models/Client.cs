using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class Client
    {
        private HttpClient HttpClient { get; set; }
        private string ApiKey { get; set; }
        public string BaseAddress { get; set; }

        public Client(string baseUrl, string apiKey)
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(baseUrl);

            ApiKey = apiKey;
            BaseAddress = baseUrl;
        }

        public async Task<HttpResponseMessage> Execute(HttpRequestMessage request)
        {
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ApiKey);
            request.Headers.Add("W-Token", ApiKey);
            return await HttpClient.SendAsync(request);
        }
    }
}
