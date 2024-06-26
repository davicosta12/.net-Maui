using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace TesteAJD.Infra
{
    public abstract class BaseService
    {
        protected string Url { get; set; }
        protected RestClient Client { get; set; }

        protected BaseService(string url)
        {
            Url = url;
            Client = new RestClient(url);
            Client.AddDefaultHeader("Content-Type", "application/json");
        }

        protected virtual async Task<T> RestExecute<T>(string route, Method method, object obj = null, Dictionary<string, string> query = null)
        {
            var request = new RestRequest(route, method);

            if (obj != null)
                request.AddBody(obj);

            if (query is not null)
                foreach (var item in query.Where(q => q.Value is not null))
                    request.AddQueryParameter(item.Key, item.Value);

            var response = await Client.ExecuteAsync(request);

            if (response.StatusCode == HttpStatusCode.NoContent)
                return default(T);

            if (!response.IsSuccessful || response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"{response.StatusCode} {response.Content ?? "..."}");

            if (typeof(T) == typeof(RestResponse))
                return (T)(object)response;

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
