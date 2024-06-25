using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class Devolution : ContentPage
{
	public Devolution(DevolutionViewModel devolutionViewModel)
	{
        BindingContext = devolutionViewModel;
        InitializeComponent();
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
    }
}