using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sheduler.Services
{
    public class SchedulerStartupService : ISchedulerStartupService, IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration configuration;


        // Cosntructor ----------------------------------------------------------------------------------------
        public SchedulerStartupService(IConfiguration configuration, IServiceProvider serviceProvider)
        {
            this.configuration = configuration;
            _serviceProvider = serviceProvider;
        }


        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var shcedulerService = scope.ServiceProvider.GetRequiredService<ISchedulerService>();
                await shcedulerService.Scheduletask();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
