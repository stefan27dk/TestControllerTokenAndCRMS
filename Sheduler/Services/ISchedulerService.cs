using System;
using System.Threading.Tasks;

namespace Sheduler.Services
{
    public interface ISchedulerService
    {
        //Task Scheduletask(Action callback);
        Task Scheduletask();
    }
}