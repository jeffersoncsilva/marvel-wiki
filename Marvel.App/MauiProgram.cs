using Marvel.App.Extension;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;


namespace Marvel.App
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
                    fonts.AddFont("Merienda-Black.ttf", "Black");
                    fonts.AddFont("Merienda-Bold.ttf", "Bold");
                    fonts.AddFont("Merienda-ExtraBold.ttf", "ExtraBold");
                    fonts.AddFont("Merienda-Light.ttf", "Light");
                    fonts.AddFont("Merienda-Medium.ttf", "Medium");
                    fonts.AddFont("Merienda-Regular.ttf", "Regular");
                    fonts.AddFont("Merienda-Semibold.ttf", "Semibold");
                });
            builder.ConfigureSyncfusionCore();
            builder.Services.AddDependencyViewModels();
            builder.Services.AddDependencyScreens();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
