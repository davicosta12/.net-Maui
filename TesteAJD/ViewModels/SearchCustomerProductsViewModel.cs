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
    public partial class SearchCustomerProductsViewModel : BaseViewModel
    {

        public SearchCustomerProductsViewModel(INavigationService navigationService) : base(navigationService)
        {
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await Task.Delay(1000);

            IsLoaded = true;
            IsFooterVisible = true;
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
