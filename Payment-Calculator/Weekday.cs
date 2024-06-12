using System;

namespace Payment_Calculator
{
    internal class Weekday
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; private set; }
        public TimeSpan Breaks { get; private set; }
        public double GrossPay { get; private set; }

        public Weekday(DateTime startTime, DateTime finishTime)
        {
            if (startTime >= finishTime)
                throw new ArgumentException("Start time must be before finish time.");

            StartTime = startTime;
            EndTime = finishTime;
            Duration = EndTime - StartTime;

            CalculateBreak(Duration);
            CalculateGrossPay(Duration, Breaks);
        }

        private void CalculateBreak(TimeSpan duration)
        {
            if (duration.TotalMinutes >= 315 && duration.TotalMinutes < 600)
            {
                Breaks = TimeSpan.FromMinutes(30);
            }
            else if (duration.TotalMinutes >= 600)
            {
                Breaks = TimeSpan.FromHours(1);
            }
            else
            {
                Breaks = TimeSpan.Zero;
            }
        }

        private void CalculateGrossPay(TimeSpan duration, TimeSpan breaks)
        {
            double totalHours = duration.TotalHours - breaks.TotalHours;
            double payRate = 25.27490;
            GrossPay = totalHours * payRate;
        }
    }
}
