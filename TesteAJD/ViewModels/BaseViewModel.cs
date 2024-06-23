using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        protected readonly INavigationService _navigationService;

        [ObservableProperty]
        private bool _isLoaded = false;

        [ObservableProperty]
        private bool _IsFooterVisible = false;

        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        private void HandleSubmit()
        {
            _navigationService.NavigateToAsync($"{nameof(Finished)}");
        }

        [RelayCommand]
        private void GoBack()
        {
            _navigationService.NavigateToAsync($"/{nameof(ProductList)}");
        }
    }
}
