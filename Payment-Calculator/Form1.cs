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

        public void Form1_Load(object sender, EventArgs e)
        {
            //create an object for each day using the start time and finish time from each changed input
            Weekday monday = new Weekday(inputMonStartTimePicker.Value, inputMonFinishTimePicker.Value);
            Weekday tuesday = new Weekday(inputTueStartTimePicker.Value, inputTueFinishTimePicker.Value);
            Weekday wednesday = new Weekday(inputWedStartTimePicker.Value, inputWedFinishTimePicker.Value);
            Weekday thursday = new Weekday(inputThurStartTimePicker.Value, inputThurFinishTimePicker.Value);
            Weekday friday = new Weekday(inputFriStartTimePicker.Value, inputFriFinishTimePicker.Value);
            Weekday saturday = new Weekday(inputSatStartTimePicker.Value, inputSatFinishTimePicker.Value);
            Weekday sunday = new Weekday(inputSunStartTimePicker.Value, inputSunFinishTimePicker.Value);
        }

        private void do_Calculations(object sender, EventArgs e)    //method that is run when "Calculate Hours" button is pressed
        {
            //on click, check if there are any changes to all start and finish time boxes -- potentially add a checkbox to each day (will require minor redesign of gui)

            //if there is an error, display a popup box preventing any calculations until rectified

            //have each object run the method (inside WEEKDAY class) calculating scheduled hours and breaks

            //display scheduled hours and break
            resultMonHoursScheduled.Text = monday.Duration.ToString(@"hh\:mm");
            resultMonBreaks.Text = monday.Breaks.ToString(@"hh\:mm");
            resultTueHoursScheduled.Text = tuesday.Duration.ToString(@"hh\:mm");
            resultTueBreaks.Text = tuesday.Breaks.ToString(@"hh\:mm");
            resultWedHoursScheduled.Text = wednesday.Duration.ToString(@"hh\:mm");
            resultWedBreaks.Text = wednesday.Breaks.ToString(@"hh\:mm");
            resultThurHoursScheduled.Text = thursday.Duration.ToString(@"hh\:mm");
            resultThurBreaks.Text = thursday.Breaks.ToString(@"hh\:mm");
            resultFriHoursScheduled.Text = friday.Duration.ToString(@"hh\:mm");
            resultFriBreaks.Text = friday.Breaks.ToString(@"hh\:mm");
            resultSatHoursScheduled.Text = saturday.Duration.ToString(@"hh\:mm");
            resultSatBreaks.Text = saturday.Breaks.ToString(@"hh\:mm");
            resultSunHoursScheduled.Text = sunday.Duration.ToString(@"hh\:mm");
            resultSunBreaks.Text = sunday.Breaks.ToString(@"hh\:mm");

            //send the calculated hours to PAYMENT class to calculate gross pay

            //display the gross amount within each time box

            //combine all amounts of gross pay and send to TAX class

            //calculate tax by running method (within TAX class) and return tax amount

            //calculate net pay (within PAYMENT class) using tax amount

            //display tax amount and net pay amount


        }

    }
}