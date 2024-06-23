using TesteAJD.Views;

namespace TesteAJD
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(SearchCustomerProducts), typeof(SearchCustomerProducts));
            Routing.RegisterRoute(nameof(ProductList), typeof(ProductList));
            Routing.RegisterRoute(nameof(ProductDetail), typeof(ProductDetail));
            Routing.RegisterRoute(nameof(Devolution), typeof(Devolution));
            Routing.RegisterRoute(nameof(Replacement), typeof(Replacement));
            Routing.RegisterRoute(nameof(Finished), typeof(Finished));
        }
    }
}
