using System;
using Microsoft.Extensions.Configuration;

namespace Likvido.Configurations
{
    public static class ConsoleAppConfiguration
    {
        public static IConfiguration Build(
            string[]? args = null,
            Action<IConfigurationBuilder>? configureAppConfiguration = null)
        {
            var builder = new ConfigurationBuilder()
                .ApplyAppConfiguration(args);
            configureAppConfiguration?.Invoke(builder);
            return builder.Build();
        }
    }
}
