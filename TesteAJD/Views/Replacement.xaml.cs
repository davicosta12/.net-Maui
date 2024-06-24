using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class Replacement : ContentPage
{
    public Replacement(ReplacementViewModel replacementViewModel)
    {
        InitializeComponent();
        BindingContext = replacementViewModel;
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
    }
}