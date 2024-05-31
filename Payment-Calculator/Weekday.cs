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
        DateTime startTime;
        DateTime endTime;

        //properties

        //constructor
        public Weekday(DateTime startTime, DateTime finishTime)
        {
            this.startTime = startTime;
            this.endTime = finishTime;
        }

        //methods
        private TimeSpan ScheduledHours(string startTime, string finishTime)
        {
            TimeSpan duration = DateTime.Parse(finishTime).Subtract(DateTime.Parse(startTime));
            CalculateBreaks(duration);
            return duration;
        }

        private void CalculateBreaks(TimeSpan duration)
        {
            //find break times
            TimeSpan breaks = TimeSpan.Zero;
            bool breaksErrorMsg = false;

            if (duration.Hours <= 5)
            {
                if (duration.Minutes < 15)
                {
                    breaks = TimeSpan.Zero;
                }
                else
                {
                    breaks = TimeSpan.FromMinutes(30);
                }
            }
            else if (duration.Hours <= 10)
            {
                if (duration.Minutes < 15)
                {
                    breaks = TimeSpan.FromMinutes(30);
                }
                else
                {
                    breaks = TimeSpan.FromHours(1);
                }
            }
            else if (duration.Hours < 12)
            {
                breaks = TimeSpan.FromHours(1);
            }
            else if (duration.Hours == 12 && duration.Minutes == 0)
            {
                breaks = TimeSpan.FromHours(1);
            }
            else if (duration.Hours == 12 && duration.Minutes > 0)
            {
                breaksErrorMsg = true;
            }
            else { breaksErrorMsg = true; }

            //display breaks
            if (breaksErrorMsg == true)
            {
                resultMonBreaks.Text = "An error occurred.";
            }
            else
            {
                resultMonBreaks.Text = breaks.ToString(@"hh\:mm");
            }
            CalculateGrossPay(duration, breaks);
        }
    }
}
