using Microsoft.Extensions.Configuration;

namespace Likvido.Configurations
{
    public static class HostedAppConfiguration
    {
        public static void ApplyHostedAppConfiguration(this IConfigurationBuilder cb, string[]? args = null)
        {
            //removing everything besides the very first source `ChainedConfigurationSource`
            //added by Host.CreateDefaultBuilder
            while (cb.Sources.Count > 1)
            {
                cb.Sources.RemoveAt(1);
            }
            cb.ApplyAppConfiguration(args);
        }
    }
}
