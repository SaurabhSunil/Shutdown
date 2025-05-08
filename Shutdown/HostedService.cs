using Microsoft.Extensions.Hosting;

namespace Shutdown
{
    public sealed class HostedService : IHostedService
    {
        public HostedService()
        {
        }

        /// <inheritdoc />
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Starting my Application...");
            await Task.Delay(1000, cancellationToken);
            Console.WriteLine("Started my Application...");
        }

        /// <inheritdoc />
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stopping my Application Started...");
            await Task.Delay(5000, cancellationToken);
            Console.WriteLine("Stopped my Application...");
        }
    }
}