using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Navigator.Configuration;
using Navigator.Configuration.Extension;

namespace Navigator.Extensions.Probabilities;

/// <summary>
/// Extension configuration.
/// </summary>
public static class NavigatorExtensionConfigurationExtensions
{
    public static NavigatorConfiguration Interop(this NavigatorExtensionConfiguration extensionConfiguration)
    {
        return extensionConfiguration.Extension(
        configuration =>
        {
            configuration.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ProbabilitiesActionMiddleware<,>));
        });
    }
}