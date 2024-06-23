using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class ProductList : ContentPage
{
	public ProductList(ProductListViewModel productListViewModel)
	{
        InitializeComponent();
        BindingContext = productListViewModel;
    }
}