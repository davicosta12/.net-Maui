using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class ProductListView : ContentPage
{
	public ProductListView()
	{
        InitializeComponent();
        BindingContext = new ProductDetailsViewModel();
    }
}