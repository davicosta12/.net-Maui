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

        [ObservableProperty]
        private bool _isLoaded = true;

        readonly ILoginRepository _loginRepository;

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            _loginRepository = new LoginService();
        }

        [RelayCommand]
        private void NavigationToProductList()
        {
            IsLoaded = false;

            //await Task.Delay(50000);

            IsLoaded = true;

            _navigationService.NavigateToAsync(nameof(ProductList));
        }
    }
}
