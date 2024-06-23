namespace TesteAJD.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToAsync(string ContentPageName, IDictionary<string, object>? parameters = null)
        {
            if (parameters == null)
            {
                await Shell.Current.GoToAsync(ContentPageName);
            }
            else
            {
                await Shell.Current.GoToAsync(ContentPageName, parameters);
            }
        }
    }
}
