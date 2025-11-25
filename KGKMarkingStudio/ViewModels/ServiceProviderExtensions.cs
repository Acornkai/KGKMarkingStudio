using System;

namespace KGKMarkingStudio.ViewModels;

public static class ServiceProviderExtensions
{
    public static T? GetService<T> (this IServiceProvider? serviceProvider)
    {
        return (T?)serviceProvider?.GetService(typeof(T)); 
    }

    public static TR? GetService<T, TR>(this IServiceProvider? serviceProvider, Func<T?, TR?> transform)
    {
        return transform((T?)serviceProvider?.GetService(typeof(T)));
    }

}
