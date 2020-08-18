# Abp.AspNetCoreRateLimit

[![NuGet](https://img.shields.io/nuget/v/EasyAbp.Abp.AspNetCoreRateLimit.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.AspNetCoreRateLimit)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.Abp.AspNetCoreRateLimit.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.AspNetCoreRateLimit)

An Abp module helps you control how often your service is used.

# Getting Started

1.Download and Install the latest `Abp.AspNetCoreRateLimit` from NuGet or via CLI:

```
PM> Install-Package EasyAbp.Abp.AspNetCoreRateLimit
PM> Install-Package EasyAbp.Abp.AspNetCoreRateLimit.Client
PM> Install-Package EasyAbp.Abp.AspNetCoreRateLimit.Ip
```

   1.  Added `[DependsOn(typeof(AbpClientLimiterModule))]` attribute to the module.
   2.  Added `[DependsOn(typeof(AbpIpLimiterModule))]` attribute to the module.

2.Extends IHostBuilder with Limiter configuration methods.

```csharp
IHostBuilder.UseAspNetCoreRateLimitIp();
IHostBuilder.UseAspNetCoreRateLimitClient();
```

3.Register the middleware below within the `OnApplicationInitialization()` method of `AppModule.cs` "before" the `UseRouting()` `middleware`:

```csharp
app.UseIpRateLimiting();
app.UseClientRateLimiting();
```

4.Add the following code at `ConfigureServices()` method 

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
      
