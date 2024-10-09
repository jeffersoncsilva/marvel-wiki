using Marvel.App.Screens;

namespace Marvel.App.Extension;

public static class AddScreensDependency
{
    public static void AddDependencyScreens(this IServiceCollection services)
    {
        services.AddScoped<Home>();
        services.AddScoped<Favorits>();
        services.AddScoped<ComingSoon>();
    }
}
