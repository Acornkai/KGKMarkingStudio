using KGKMarkingStudio.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace KGKMarkingStudio.Services;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        collection.AddTransient<MainViewModel>();
    }
}