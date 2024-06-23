using TesteAJD.Views;

namespace TesteAJD
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(ProductList), typeof(ProductList));
            Routing.RegisterRoute(nameof(Devolution), typeof(Devolution));
        }
    }
}
