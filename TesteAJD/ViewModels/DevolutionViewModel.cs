using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;
using TesteAJD.Model;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    [QueryProperty(nameof(Products), "Products")]
    public partial class DevolutionViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<ProductListModel> _products;

        public DevolutionViewModel(INavigationService navigationService) : base(navigationService)
        {
          
        }

        [RelayCommand]
        private void GoBack()
        {
            _navigationService.NavigateToAsync($"/{nameof(ProductList)}");
        }
    }
}
