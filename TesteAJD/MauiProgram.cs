using Microsoft.Extensions.Logging;
using TesteAJD.Services;
using TesteAJD.ViewModels;
using TesteAJD.Views;

namespace TesteAJD
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<INavigationService, NavigationService>();

            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<Login>();

            builder.Services.AddTransient<ProductListViewModel>();
            builder.Services.AddTransient<ProductList>();

            builder.Services.AddTransient<DevolutionViewModel>();
            builder.Services.AddTransient<Devolution>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
