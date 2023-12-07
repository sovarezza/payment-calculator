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

        private void calculate_HoursWorked(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Parse(finishTimePicker2.Value.ToString()).Subtract(DateTime.Parse(startdateTimePicker1.Value.ToString()));
            hoursWorkedlabel2.Text = duration.ToString(@"hh\:mm");
            CalculateBreaks(duration);
            CalculateGrossPay();
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
        }

        private void CalculateGrossPay()
        {
            //get age

            //determine pay reasoning

            //calculate pay

            //display pay
            grossPaylabel2.Text = "";
        }
    }
}