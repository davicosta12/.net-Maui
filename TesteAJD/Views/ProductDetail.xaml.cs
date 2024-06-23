using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class ProductDetail : ContentPage
{
	public ProductDetail(ProductDetailViewModel productDetailViewModel)
	{
		InitializeComponent();
        BindingContext = productDetailViewModel;
    }
}