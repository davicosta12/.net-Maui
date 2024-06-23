using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAJD.Model;
using TesteAJD.Services;
using TesteAJD.Views;

namespace TesteAJD.ViewModels
{
    [QueryProperty(nameof(OutPutItems), "OutPutItems")]
    public partial class ReplacementViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<ProductListModel> _outPutItems;

        public ReplacementViewModel(INavigationService navigationService) : base(navigationService)
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
