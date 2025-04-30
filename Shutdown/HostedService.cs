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
        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stopping my Application...");
            return Task.CompletedTask;
        }
    }
}