using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    public partial class BaseViewModel : ObservableObject
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
        private void HandleSubmit(string operationType)
        {
            var parameter = new Dictionary<string, object>
                    {
                        {"OperationType", operationType }

                    };
            _navigationService.NavigateToAsync($"{nameof(Finished)}", parameter);
        }

        [RelayCommand]
        private void GoBack()
        {
            _navigationService.NavigateToAsync($"/{nameof(ProductList)}");
        }
    }
}
