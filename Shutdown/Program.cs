using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shutdown;
using System.Runtime.InteropServices;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<HostedService>();
        services.Configure<HostOptions>(options =>
        {
            options.ServicesStopConcurrently = true;
        });
    })
    .Build();

using var registration = PosixSignalRegistration.Create(PosixSignal.SIGTERM, context =>
{
    context.Cancel = true;
    Console.WriteLine("SIGTERM");
    host.StopAsync().GetAwaiter().GetResult();
});

await host.RunAsync();
