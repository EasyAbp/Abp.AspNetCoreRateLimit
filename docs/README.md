# Abp.AspNetCoreRateLimit

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FAbpVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FEasyAbp%2FAbp.AspNetCoreRateLimit%2Fmaster%2FDirectory.Build.props)](https://abp.io)
[![NuGet](https://img.shields.io/nuget/v/EasyAbp.Abp.AspNetCoreRateLimit.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.AspNetCoreRateLimit)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.Abp.AspNetCoreRateLimit.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.AspNetCoreRateLimit)
[![Discord online](https://badgen.net/discord/online-members/xyg8TrRa27?label=Discord)](https://discord.gg/xyg8TrRa27)
[![GitHub stars](https://img.shields.io/github/stars/EasyAbp/Abp.AspNetCoreRateLimit?style=social)](https://www.github.com/EasyAbp/Abp.AspNetCoreRateLimit)

An Abp module helps you control how often your service is used.

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/How-To.md#add-nuget-packages))

    * EasyAbp.Abp.AspNetCoreRateLimit.AspNetCoreRateLimit
    * EasyAbp.Abp.AspNetCoreRateLimit.AspNetCoreRateLimit.Client
    * EasyAbp.Abp.AspNetCoreRateLimit.AspNetCoreRateLimit.Ip

1. Add `DependsOn(typeof(AbpClientLimiterModule))` and `DependsOn(typeof(AbpIpLimiterModule))` attribute to configure the module dependencies. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/How-To.md#add-module-dependencies))


1. Extends IHostBuilder with Limiter configuration methods.

    ```csharp
    IHostBuilder.UseAspNetCoreRateLimitIp();
    IHostBuilder.UseAspNetCoreRateLimitClient();
    ```

1. Register the middleware below within the `OnApplicationInitialization()` method of `AppModule.cs` "before" the `UseRouting()` `middleware`:

    ```csharp
    app.UseIpRateLimiting();
    app.UseClientRateLimiting();
    ```

1. Add the following code at `ConfigureServices()` method 

    ```csharp
    context.Services.AddLimiterService<MemoryCacheRateLimitCounterStore>(service =>
    {
        service.AddLimiterIpService<MemoryCacheIpPolicyStore>();
        service.AddLimiterClientService<MemoryCacheClientPolicyStore>();
    });
    ```


# Documentation

Rate limiting based on client IP

  - [Setup and configuration](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/IpRateLimitMiddleware#setup)
  - [Defining rate limit rules](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/IpRateLimitMiddleware#defining-rate-limit-rules)
  - [Behavior](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/IpRateLimitMiddleware#behavior)
  - [Update rate limits at runtime](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/IpRateLimitMiddleware#update-rate-limits-at-runtime)

Rate limiting based on client ID

  - [Setup and configuration](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/ClientRateLimitMiddleware#setup)
  - [Defining rate limit rules](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/ClientRateLimitMiddleware#defining-rate-limit-rules)
  - [Behavior](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/ClientRateLimitMiddleware#behavior)
  - [Update rate limits at runtime](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/ClientRateLimitMiddleware#update-rate-limits-at-runtime)

Advanced configuration

  - [Customize the quoata exceeded response](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/Quota-exceeded-response)
  - [IP / ClientId resolve contributors](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/Resolve-Contributors)
  - [Use Redis as a distributed counter store](https://github.com/stefanprodan/AspNetCoreRateLimit/wiki/Using-Redis-as-a-distributed-counter-store)

# Roadmap

- [ ] Unit test
      
