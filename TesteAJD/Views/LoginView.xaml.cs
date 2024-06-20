using TesteAJD.ViewModels;

namespace TesteAJD.Views
{
    public partial class LoginView : ContentPage
    {
        //int count = 0;

        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //  count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //   SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }
}
