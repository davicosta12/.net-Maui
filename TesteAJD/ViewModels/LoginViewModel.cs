using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Caching.Memory;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _tenantUrl = "";

        [ObservableProperty]
        private string _userName = "";

        [ObservableProperty]
        private string _password = "";

        readonly ILoginRepository _loginService;

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [RelayCommand]
        private async void NavigationToSearchCustomerProducts()
        {
            var _loginService = new LoginService(UserName, Password, IMemoryCache memoryCache);

            await _loginService.LoginAsync(TenantUrl, UserName, Password);

            _navigationService.NavigateToAsync(nameof(SearchCustomerProducts));
        }
    }
}
