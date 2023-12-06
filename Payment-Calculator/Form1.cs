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
        }
    }
}