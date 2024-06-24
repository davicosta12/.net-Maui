using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class ProductDetail : ContentPage
{
    ProductDetailViewModel _productDetailViewModel;

    public ProductDetail(ProductDetailViewModel productDetailViewModel)
	{
		InitializeComponent();
        BindingContext = _productDetailViewModel = productDetailViewModel;
    }

    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
        //_productDetailViewModel.ChageFooterVisibility(e.ScrollY);
    }
}