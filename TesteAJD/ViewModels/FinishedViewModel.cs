using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    public partial class FinishedViewModel : BaseViewModel
    {
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
