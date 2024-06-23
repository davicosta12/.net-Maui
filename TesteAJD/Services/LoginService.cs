using TesteAJD.Models;

namespace TesteAJD.Services
{
    class LoginService : ILoginRepository
    {
        public Task<UserInfo> Login(string username, string password)
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
                throw new NotImplementedException();
            }

            throw new NotImplementedException();
        }
    }
}
