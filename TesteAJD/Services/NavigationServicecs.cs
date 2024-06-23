namespace TesteAJD.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigateToAsync(string ContentPageName, IDictionary<string, object>? parameters = null)
        {
            return parameters == null 
                ? Shell.Current.GoToAsync(ContentPageName) 
                : Shell.Current.GoToAsync(ContentPageName, parameters);
        }
    }
}
