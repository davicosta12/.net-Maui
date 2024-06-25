using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        readonly ILoginRepository _loginRepository;

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            _loginRepository = new LoginService();
        }

        [RelayCommand]
        private void NavigationToSearchCustomerProducts()
        {
            _navigationService.NavigateToAsync(nameof(SearchCustomerProducts));
        }
    }
}
