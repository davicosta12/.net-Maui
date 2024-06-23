using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TesteAJD.Model;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    public partial class ProductListViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<ProductGroup> _productGroup;

        [ObservableProperty]
        private ObservableCollection<ProductListModel> _selectedProducts;

        [ObservableProperty]
        private bool _isLoaded = false;

        public ICommand OnSelectionChangedCommand { get; }

        public ProductListViewModel(INavigationService navigationService) : base(navigationService)
        {
            ProductGroup = new ObservableCollection<ProductGroup>();
            SelectedProducts = new ObservableCollection<ProductListModel>();
            OnSelectionChangedCommand = new RelayCommand<object>(OnSelectionChanged);
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await PopulateDataAsync();
        }

        async Task PopulateDataAsync()
        {
            await Task.Delay(1000);
            //TODO: Remove Delay here and call API

            ProductGroup.Clear();

            ProductGroup.Add(new ProductGroup("Caedu", new ObservableCollection<ProductListModel>
            {
                new ProductListModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = "$755", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" },
                new ProductListModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = "$450", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" },
                new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = "$900", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" }
            }));

            ProductGroup.Add(new ProductGroup("Jchermann", new ObservableCollection<ProductListModel>
            {
                new ProductListModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = "$1200", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" },
                new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Bang and Olufsen", Price = "$90", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" },
                new ProductListModel() { Name = "B&o Desk Lamp", BrandName = "Bang and Olufsen", Price = "$450", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image7.png" }
            }));

            ProductGroup.Add(new ProductGroup("Torra", new ObservableCollection<ProductListModel>
            {
               new ProductListModel() { Name = "BeoPlay Stand Speaker", BrandName = "Bang and Olufse", Price = "$3000", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image8.png" },
               new ProductListModel() { Name = "Airpods", BrandName = "B&o Phone Case", Price = "$30", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image9.png" }
            }));

            IsLoaded = true;
        }

        private void OnSelectionChanged(object? sender)
        {
            if (sender is CollectionView collectionView)
            {
                var selectedProducts = new List<ProductListModel>();

                foreach (var selectedItem in collectionView.SelectedItems)
                {
                    if (selectedItem is ProductListModel product)
                    {
                        selectedProducts.Add(product);
                    }
                }

                SelectedProducts = new ObservableCollection<ProductListModel>(selectedProducts);
            }
        }

        [RelayCommand]
        private void NavigationToDevolution(ObservableCollection<ProductListModel> selectedProducts)
        {
            var parameter = new Dictionary<string, object>
                    {
                        {"Products", selectedProducts }
                    };

            _navigationService.NavigateToAsync(nameof(Devolution), parameter);
        }
    }
}
