using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shutdown;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<HostedService>();
        services.Configure<HostOptions>(options =>
        {
            // Set the timeout for graceful shutdown to 10 seconds
            options.ShutdownTimeout = TimeSpan.FromSeconds(30);

            options.ServicesStopConcurrently = true;
            //options.ServicesStartConcurrently = true;
            //options.ServicesStopConcurrently = true;
        });
    })
    .Build();

await host.RunAsync();