# Likvido.Configurations
Simple library which makes default configuration easier
## ConsoleAppConfiguration
Intended to be used by simple console apps
```
var appConfiguration = ConsoleAppConfiguration.Build(args);
```
## HostedAppConfiguration
Intended to be used by long running apps with a host. Like worker services, APIs, webapps
```
Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(cb => cb.ApplyHostedAppConfiguration(args)) 
```