using TesteAJD.ViewModels;

namespace TesteAJD.Views
{
    public partial class Login : ContentPage
    {
        public Login(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            BindingContext = loginViewModel;
        }
    }
}
