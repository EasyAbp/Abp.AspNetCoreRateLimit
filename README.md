# Abp.UsingLimiter

An Abp module helps you control how often your service is used.

# Getting Started

1、Download and Install the latest `Abp.UsingLimiter` from NuGet or via CLI:

```
PM> Install-Package EasyAbp.Abp.UsingLimiter
PM> Install-Package EasyAbp.Abp.UsingLimiter.Client
PM> Install-Package EasyAbp.Abp.UsingLimiter.Ip
```

   1.  Added `[DependsOn(typeof(AbpLimiterModule))]` attribute to the module.
   1.  Added `[DependsOn(typeof(AbpClientLimiterModule))]` attribute to the module.
   1.  Added `[DependsOn(typeof(AbpIpLimiterModule))]` attribute to the module.

2、Extends IHostBuilder with Limiter configuration methods.

```csharp
IHostBuilder.UseAbpLimiter(RateLimitType.All);
```

3、Declare the following namespace within `AppModule.cs`

```csharp
using EasyAbp.Abp.UsingLimiter.DependencyInjection;
//client rate limiting
using EasyAbp.Abp.UsingLimiter.Client;
using EasyAbp.Abp.UsingLimiter.Client.DependencyInjection;
//Ip rate limiting
using EasyAbp.Abp.UsingLimiter.Ip;
using EasyAbp.Abp.UsingLimiter.Ip.DependencyInjection;

```

4、Register the middleware below within the `OnApplicationInitialization()` method of `AppModule.cs` "before" the `UseRouting()` `middleware`:

```csharp
app.UseIpRateLimiting();
app.UseClientRateLimiting();
```

5、Add the following code at `ConfigureServices()` method 

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

# Roadmap

- [ ] Unit test
      