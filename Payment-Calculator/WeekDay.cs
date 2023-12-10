using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Calculator
{
    internal class WeekDay
    {
        //fields
        DateTime startTime;
        DateTime endTime;

        //properties



        //constructor
        public WeekDay(DateTime startTime, DateTime finishTime) 
        {
            this.startTime = startTime;
            this.endTime = finishTime;
        }

        //methods

        private void DoCalculations()
        {

        }

        private TimeSpan ScheduledHours(string start, string finish)
        {
            TimeSpan duration = DateTime.Parse(finish).Subtract(DateTime.Parse(start));
            //resultMonHoursScheduled.Text = duration.ToString(@"hh\:mm");
            //CalculateBreaks(duration);
            return duration;
        }
    }
}
