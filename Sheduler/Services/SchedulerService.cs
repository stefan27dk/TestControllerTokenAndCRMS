using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sheduler.Services
{
    public class SchedulerService : ISchedulerService
    {
        private System.Threading.Timer timer = null;


        // Constructor
        public SchedulerService()
        {
          
        }


        private void SetupTimer()
        {
            //DateTime currentTime = DateTime.Now;
            //DateTime timerRunningTime = new DateTime(currentTime.Year,
            //currentTime.Month, currentTime.Day, 2, 0, 0);
            //timerRunningTime = timerRunningTime.AddDays(15);
            ////DateTime timerRunningTime = DateTime.Now.AddMinutes(2);  

            //double tickTime = (double)(timerRunningTime – DateTime.Now).TotalSeconds;

            //timer.Change(TimeSpan.FromSeconds(5),
            // TimeSpan.FromSeconds(5));
        }

        // https://stackoverflow.com/questions/59727799/how-to-run-net-core-ihosted-service-at-specific-time-of-the-day
        // https://stackoverflow.com/questions/18611226/c-how-to-start-a-thread-at-a-specific-time
        // https://www.c-sharpcorner.com/blogs/how-to-run-a-timer-on-specific-time-interval



        //public Task Scheduletask(Action callback)
        public Task Scheduletask()
        {
            return Task.Run(() =>
            {
                //this.timer = new System.Threading.Timer(x => {callback();}, null,  DateTime.Now.Year, new TimeSpan(24, 0, 0));
                this.timer = new System.Threading.Timer(x => { System.Diagnostics.Debug.WriteLine("Executed Timer"); }, null, TimeSpan.Zero, new TimeSpan(0, 0, 5));
            });
        }
    }
}
