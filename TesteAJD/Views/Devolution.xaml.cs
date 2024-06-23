using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class Devolution : ContentPage
{
	public Devolution(DevolutionViewModel devolutionViewModel)
	{
        InitializeComponent();
        BindingContext = devolutionViewModel;
    }
}