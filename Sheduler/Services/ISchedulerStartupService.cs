using System.Threading;
using System.Threading.Tasks;

namespace Sheduler.Services
{
    public interface ISchedulerStartupService
    {
        Task StartAsync(CancellationToken cancellationToken);
        Task StopAsync(CancellationToken cancellationToken);
    }
}