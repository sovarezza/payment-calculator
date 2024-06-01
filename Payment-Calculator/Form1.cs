/* 
 * Author: C. James Bradley
 * Project start date: 01/12/2023
 * Description:
 * This is a pay calculator specifically tailored around the Austrlian supermarket chain 'Coles'.
 * It is intended to provide only a certain level of accuracy and will not be 100% accurate.
 */

using Microsoft.VisualBasic;

namespace Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //combine all amounts of gross pay

        //calculate tax by running method and return tax amount

        //calculate net pay using tax amount

        //display tax amount and net pay amount


        //create an object for each day using the start time and finish time from each changed input
        //have each object run the method (inside WEEKDAY class) calculating scheduled hours and breaks
        //display scheduled hours and break
        //send the calculated hours to PAYMENT class to calculate gross pay and display within each Day box
        private void Mon_Calculations(object sender, EventArgs e)       //runs when MonFinishTimePicker is changed
        {
            Weekday monday = new Weekday(inputMonStartTimePicker.Value, inputMonFinishTimePicker.Value);
            resultMonHoursScheduled.Text = monday.Duration.ToString(@"hh\:mm");
            resultMonBreaks.Text = monday.Breaks.ToString(@"hh\:mm");
            resultMonGrossPay.Text = Payment.CalculateGrossPay(monday.Duration, monday.Breaks).ToString("C");
        }

        private void Tue_Calculations(object sender, EventArgs e)       //runs when TueFinishTimePicker is changed
        {
            Weekday tuesday = new Weekday(inputTueStartTimePicker.Value, inputTueFinishTimePicker.Value);
            resultTueHoursScheduled.Text = tuesday.Duration.ToString(@"hh\:mm");
            resultTueBreaks.Text = tuesday.Breaks.ToString(@"hh\:mm");
            resultTueGrossPay.Text = Payment.CalculateGrossPay(tuesday.Duration, tuesday.Breaks).ToString("C");
        }

        private void Wed_Calculations(object sender, EventArgs e)
        {
            Weekday wednesday = new Weekday(inputWedStartTimePicker.Value, inputWedFinishTimePicker.Value);
            resultWedHoursScheduled.Text = wednesday.Duration.ToString(@"hh\:mm");
            resultWedBreaks.Text = wednesday.Breaks.ToString(@"hh\:mm");
            resultWedGrossPay.Text = Payment.CalculateGrossPay(wednesday.Duration, wednesday.Breaks).ToString("C");
        }

        private void Thu_Calculations(object sender, EventArgs e)
        {
            Weekday thursday = new Weekday(inputThurStartTimePicker.Value, inputThurFinishTimePicker.Value);
            resultThurHoursScheduled.Text = thursday.Duration.ToString(@"hh\:mm");
            resultThurBreaks.Text = thursday.Breaks.ToString(@"hh\:mm");
            resultThurGrossPay.Text = Payment.CalculateGrossPay(thursday.Duration, thursday.Breaks).ToString("C");
        }

        private void Fri_Calculations(object sender, EventArgs e)
        {
            Weekday friday = new Weekday(inputFriStartTimePicker.Value, inputFriFinishTimePicker.Value);
            resultFriHoursScheduled.Text = friday.Duration.ToString(@"hh\:mm");
            resultFriBreaks.Text = friday.Breaks.ToString(@"hh\:mm");
            resultFriGrossPay.Text = Payment.CalculateGrossPay(friday.Duration, friday.Breaks).ToString("C");
        }

        private void Sat_Calculations(object sender, EventArgs e)
        {
            Weekday saturday = new Weekday(inputSatStartTimePicker.Value, inputSatFinishTimePicker.Value);
            resultSatHoursScheduled.Text = saturday.Duration.ToString(@"hh\:mm");
            resultSatBreaks.Text = saturday.Breaks.ToString(@"hh\:mm");
            resultSatGrossPay.Text = Payment.CalculateGrossPay(saturday.Duration, saturday.Breaks).ToString("C");
        }

        private void Sun_Calculations(object sender, EventArgs e)
        {
            Weekday sunday = new Weekday(inputSunStartTimePicker.Value, inputSunFinishTimePicker.Value);
            resultSunHoursScheduled.Text = sunday.Duration.ToString(@"hh\:mm");
            resultSunBreaks.Text = sunday.Breaks.ToString(@"hh\:mm");
            resultSunGrossPay.Text = Payment.CalculateGrossPay(sunday.Duration, sunday.Breaks).ToString("C");
        }

        private void Do_Calculations(object sender, EventArgs e)        //runs when Calculate Hours button is clicked
        {

        }
    }
}