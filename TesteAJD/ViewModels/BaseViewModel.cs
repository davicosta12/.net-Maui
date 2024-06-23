using CommunityToolkit.Mvvm.ComponentModel;
using TesteAJD.Services;

namespace TesteAJD.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        protected readonly INavigationService _navigationService;

        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
