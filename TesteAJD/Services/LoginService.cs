using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;
using TesteAJD.Infra;
using TesteAJD.Models;

namespace TesteAJD.Services
{
    public class LoginService : ILoginRepository
    {
        private readonly RestOmsServices _restOmsServices;

        public LoginService(string url, string user, string passwd, IMemoryCache memoryCache)
        {
            _restOmsServices = new RestOmsServices(url, user, passwd, memoryCache);
        }

        public async Task<CompanyUserToken> LoginAsync()
        {
            CompanyUserToken userToken = new();

            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    userToken = await _restOmsServices.TokenAsync();
                    return userToken;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(@"\tERROR {0}", ex.Message);
                }
            }

            return userToken;
        }
    }
}
