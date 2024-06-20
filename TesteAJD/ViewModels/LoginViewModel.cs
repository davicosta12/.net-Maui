using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TesteAJD.Model;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private bool _IsLoaded = false;

        public ICommand RedirectToProductListCommand { get; }

        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }

        private ObservableCollection<ProductListModel> _BestSellingDataList = [];
        public ObservableCollection<ProductListModel> BestSellingDataList
        {
            get => _BestSellingDataList;
            set => SetProperty(ref _BestSellingDataList, value);
        }

        public LoginViewModel()
        {
            RedirectToProductListCommand = new Command<ProductListModel>(RedirectToProductList);
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await PopulateDataAsync();
        }

        async Task PopulateDataAsync()
        {
            // Delay added to display loading, remove during api call
            await Task.Delay(500);

            //TODO: Remove Delay here and call API

            BestSellingDataList.Add(new ProductListModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = "$755", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = "$450", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = "$900", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = "$1200", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });

            IsLoaded = true;
        }

        private async void RedirectToProductList(ProductListModel obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ProductListView());
        }
    }
}
