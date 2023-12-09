using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Calculator
{
    internal class WeekDays
    {
        //fields
        DateTime startTime;
        DateTime endTime;
        TimeSpan duration;
        TimeSpan lunchBreaks;
        TimeSpan mealBreaks;
        double grossPay;
        double taxAmount; //might go into a separate class for tax-related information
        double netPay;


        //properties


        //constructor
        public WeekDays() { }

        //method
    }
}
