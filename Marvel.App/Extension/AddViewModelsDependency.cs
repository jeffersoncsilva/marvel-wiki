using Mavel.ViewModels.Screens;

namespace Marvel.App.Extension;

public static class AddViewModelsDependency
{
    public static void AddDependencyViewModels(this IServiceCollection services)
    {
        services.AddScoped<HomeViewModel>();
        services.AddScoped<FavoritsViewModel>();
        services.AddScoped<ComingSoonViewModel>();
    }
}
