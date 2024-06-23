using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using TesteAJD.Model;
using TesteAJD.Models;
using TesteAJD.Services;

namespace TesteAJD.ViewModels
{
    [QueryProperty(nameof(CurrentProduct), "CurrentProduct")]
    public partial class ProductDetailViewModel : BaseViewModel
    {

        [ObservableProperty]
        private ProductDetailModel _productDetail = new();

        [ObservableProperty]
        private ProductListModel _currentProduct = new();

        [ObservableProperty]
        private bool _isFooterVisible = false;

        [ObservableProperty]
        private bool _isLoaded = false;


        public ProductDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
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
            ProductDetail.Price = 1500;
            ProductDetail.Name = "Nike Dri-FIT Long Sleeve";
            ProductDetail.ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image10.png";
            ProductDetail.Colors = Color.FromArgb("#33427D");
            ProductDetail.Details = "Nike Dri-FIT is a polyester fabric designed to help you keep dry so you can more comfortably work harder, longer.";

            List<ReviewModel> reviewData =
            [
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user1.png", Name = "Samuel Smith", Review = "Wonderful jean, perfect gift for my girl for our anniversary!", Rating = 4 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user1.png", Name = "Samuel Smith", Review = "Wonderful jean, perfect gift for my girl for our anniversary!", Rating = 4 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
            ];
            ProductDetail.Reviews = reviewData;
            IsLoaded = true;
        }
    }
}
