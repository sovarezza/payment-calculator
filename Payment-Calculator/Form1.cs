using Microsoft.VisualBasic;

namespace Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calculateHoursbutton1_Click(object sender, EventArgs e)
        {
        }

        private void do_Calculations(object sender, EventArgs e)
        {
            ScheduledHours(startdateTimePicker1.Value,finishTimePicker2.Value);
            /* 
            CalculateBreaks();
            CalculateGrossPay();
            */
        }

        private TimeSpan ScheduledHours(DateTime startTime, DateTime finishTime)
        {
            TimeSpan duration = DateTime.Parse(finishTime).Subtract(DateTime.Parse(startTime));
            hoursWorkedlabel2.Text = duration.ToString(@"hh\:mm");
            CalculateBreaks(duration);
            return duration;
        }

        private void CalculateBreaks(TimeSpan duration)
        {
            //get hours worked -- already done via argument

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
                breakslabel2.Text = "An error occurred.";
            }
            else
            {
                breakslabel2.Text = breaks.ToString(@"hh\:mm");
            }
            CalculateGrossPay(duration, breaks);
        }

        private double CalculateGrossPay(TimeSpan duration, TimeSpan breaks)
        {
            /*
            //get age

            //determine pay reasoning

            //calculate pay

            //double payAmount = 25.20954;

            //display pay
            //grossPaylabel2.Text = "";
            */
            //convert duration into double
            double scheduledHours = duration.TotalHours;

            //convert breaks into double
            double mealBreaks = breaks.TotalHours;

            //subtract breaks from duration
            double totalHours = scheduledHours-mealBreaks;

            //multiply pay amount by hours worked for gross total
            double payAmount = 23.23091;
            double grossPay = totalHours*payAmount;

            //display gross amount
            grossPaylabel2.Text = grossPay.ToString("C");

            //return gross amount
            return grossPay;
        }
    }
}