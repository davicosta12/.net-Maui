using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;
using TesteAJD.Model;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    [QueryProperty(nameof(SourceItems), "SourceItems")]
    public partial class DevolutionViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<ProductListModel> _sourceItems;

        public DevolutionViewModel(INavigationService navigationService) : base(navigationService)
        {
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await Task.Delay(1000);

            IsLoaded = true;
            IsFooterVisible = true;
        }
    }
}
