using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace TesteAJD.Infra
{
    public  class RestOmsServices
    {
        private string _url { get; set; }
        private string _user { get; set; }
        private string _passwd { get; set; }

        private IMemoryCache _memoryCache;

        public RestOmsServices(string url, string user, string passwd, IMemoryCache memoryCache)
        {
            _url = url;
            _user = user;
            _passwd = passwd;
            _memoryCache = memoryCache;
        }

        public async Task<CompanyUserToken> TokenAsync()
        {
            var responseToken = new CompanyUserToken();

            try
            {
                responseToken = await _memoryCache.GetOrCreateAsync<CompanyUserToken>($"CompanyUserToken", async (cacheEntry) =>
                {
                    string api = _url.ToLower().Contains("api") ? $"{_url}/Token" : $"{_url}/Api/Token";

                    var authRest = new RestClient(api);

                    var request = new RestRequest(api, Method.Post);

                    var auth = new AuthenticationModel() { user = _user, password = _passwd };

                    string authJson = JsonConvert.SerializeObject(auth);

                    request.AddJsonBody(authJson);

                    var response = await authRest.ExecuteAsync(request);

                    if (response.IsSuccessful)
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            responseToken = JsonConvert.DeserializeObject<CompanyUserToken>(response.Content);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"TokenAsync - {response.StatusCode} - ({response.Content})");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"TokenAsync - {response.StatusCode} - ({response.Content})");
                        Console.ResetColor();
                    }

                    cacheEntry.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(30);

                    return responseToken;
                });
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TokenAsync - {e.Message}");
                Console.ResetColor();
            }

            return responseToken;
        }


        public async Task<T> ExecuteAsync<T>(string route, Method method, object obj = null)
        {
            var token = await TokenAsync();

            var client = new RestClient(route);

            var request = new RestRequest(route, method);

            request.AddHeader("Content-Type", "application/json");

            if (!string.IsNullOrEmpty(token.token))
            {
                request.AddHeader("Authorization", $"bearer {token.token}");
            }

            if (obj != null)
            {
                request.AddJsonBody(obj);
            }

            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"{response.StatusCode} {response.ErrorMessage}");
            }

            if (typeof(T) == typeof(RestResponse))
            {
                return (T)(object)response;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
