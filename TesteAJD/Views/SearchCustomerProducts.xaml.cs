using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class SearchCustomerProducts : ContentPage
{
	public SearchCustomerProducts(SearchCustomerProductsViewModel searchCustomerProductsViewModel)
	{
		InitializeComponent();
        BindingContext = searchCustomerProductsViewModel;
    }
}