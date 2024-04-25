# Deprecated. We should not add this to new apps, but instead just use the standard way of reading configuration files (appsettings.json, appsettings.Development.json & appsettings.Production.json)

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/likvido/Likvido.Configurations/Publish%20to%20nuget)](https://github.com/Likvido/Likvido.Configurations/actions?query=workflow%3A%22Publish+to+nuget%22)
[![Nuget](https://img.shields.io/nuget/v/Likvido.Configurations)](https://www.nuget.org/packages/Likvido.Configurations/)
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
