using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    [QueryProperty(nameof(OperationType), "OperationType")]
    public partial class FinishedViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _operationType;

        public FinishedViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [RelayCommand]
        private void GoBackHome()
        {
            _navigationService.NavigateToAsync($"/{nameof(SearchCustomerProducts)}");
        }
    }
}
