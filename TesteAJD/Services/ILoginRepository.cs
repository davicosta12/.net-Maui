using TesteAJD.Infra;

namespace TesteAJD.Services
{
    public interface ILoginRepository
    {
        Task<CompanyUserToken> LoginAsync();
    }
}
