using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Calculator
{
    internal class Weekday
    {
        //fields
        private DateTime startTime;
        private DateTime endTime;
        private TimeSpan duration;
        private TimeSpan breaks;

        //properties
        public DateTime StartTime
        {
            get => startTime; 
            set => startTime = value;
        }

        public DateTime EndTime
        {
            get => endTime;
            set => endTime = value;
        }

        public TimeSpan Duration
        {
            get => duration;
            set => duration = value;
        }

        public TimeSpan Breaks
        {
            get => breaks;
            set => breaks = value;
        }

        //constructor
        public Weekday(DateTime startTime, DateTime finishTime)
        {
            this.startTime = startTime;
            this.endTime = finishTime;
            ScheduledHours(startTime, finishTime);
            CalculateBreak(duration);
        }

        //methods
        private TimeSpan ScheduledHours(DateTime start, DateTime end)
        {
            duration = end - start;
            return duration;
        }

        private void CalculateBreak(TimeSpan duration)
        {
            //find break times
            bool breaksErrorMsg = false;

            if (duration.Hours <= 5)
            {
                if (duration.Minutes < 15) { breaks = TimeSpan.Zero; }
                else { breaks = TimeSpan.FromMinutes(30); }
            }
            else if (duration.Hours < 10) { breaks = TimeSpan.FromMinutes(30); }
            else if (duration.Hours == 10)
            {
                if (duration.Minutes < 15) { breaks = TimeSpan.FromMinutes(30); }
                else { breaks = TimeSpan.FromHours(1); }
            }
            else if (duration.Hours < 12) { breaks = TimeSpan.FromHours(1); }
            else if (duration.Hours == 12 && duration.Minutes == 0)
            {
                breaks = TimeSpan.FromHours(1);
            }
            else if (duration.Hours == 12 && duration.Minutes > 0)
            {
                breaksErrorMsg = true;
            }
            else { breaksErrorMsg = true; }
        }
    }
}
