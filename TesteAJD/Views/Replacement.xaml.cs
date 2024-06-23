using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class Replacement : ContentPage
{
    public Replacement(ReplacementViewModel replacementViewModel)
    {
        InitializeComponent();
        BindingContext = replacementViewModel;
    }
}