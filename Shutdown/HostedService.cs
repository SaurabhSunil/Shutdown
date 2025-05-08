using Microsoft.Extensions.Hosting;

namespace Shutdown
{
    public sealed class HostedService : IHostedService
    {
        public HostedService()
        {
        }

        /// <inheritdoc />
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Starting my Application...");
            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stopping my Application started...");
            await Task.Delay(10000);
            Console.WriteLine("Stopping my Applicationafter waiting...");
        }
    }
}