using TesteAJD.ViewModels;

namespace TesteAJD.Views;

public partial class Finished : ContentPage
{
	public Finished(FinishedViewModel finishedViewModel)
	{
		InitializeComponent();
        BindingContext = finishedViewModel;
    }
}