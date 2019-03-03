using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace GitProjectWebsite.Controllers
{
    internal class GitPuller
    {
        private HttpClient HttpClient { get; set; }
        public GitPuller()
        {
            HttpClient = new HttpClient();
        }

        public List<Repository> GetAllRepositories(string user = "ElikBelik77")
        {
            List<Repository> result = new List<Repository>();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://api.github.com/users/{user}/repos");
            request.Headers.Add("User-Agent","ElikBelik77");
            HttpResponseMessage response = HttpClient.SendAsync(request).Result;
            string responseString = response.Content.ReadAsStringAsync().Result;
            JArray responseObject = JArray.Parse(responseString);

            return JsonConvert.DeserializeObject<List<Repository>>(responseString);
        } 
    }
}