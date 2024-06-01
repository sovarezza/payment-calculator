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

        private void Mon_Calculations(object sender, EventArgs e)                                                   //runs when MonFinishTimePicker is changed
        {
            Weekday monday = new Weekday(inputMonStartTimePicker.Value, inputMonFinishTimePicker.Value);            //create object, use start and finish times to populate fields/properties
            resultMonHoursScheduled.Text = monday.Duration.ToString(@"hh\:mm");                                     //display scheduled hours duration 
            resultMonBreaks.Text = monday.Breaks.ToString(@"hh\:mm");                                               //display unpaid meal breaks
            resultMonGrossPay.Text = monday.GrossPay.ToString("C");                                                 //display gross pay (scheduled hours minus unpaid meal breaks)
        }

        private void Tue_Calculations(object sender, EventArgs e)                                                   //runs when TueFinishTimePicker is changed
        {
            Weekday tuesday = new Weekday(inputTueStartTimePicker.Value, inputTueFinishTimePicker.Value);
            resultTueHoursScheduled.Text = tuesday.Duration.ToString(@"hh\:mm");
            resultTueBreaks.Text = tuesday.Breaks.ToString(@"hh\:mm");
            resultTueGrossPay.Text = tuesday.GrossPay.ToString("C");
        }

        private void Wed_Calculations(object sender, EventArgs e)
        {
            Weekday wednesday = new Weekday(inputWedStartTimePicker.Value, inputWedFinishTimePicker.Value);
            resultWedHoursScheduled.Text = wednesday.Duration.ToString(@"hh\:mm");
            resultWedBreaks.Text = wednesday.Breaks.ToString(@"hh\:mm");
            resultWedGrossPay.Text = wednesday.GrossPay.ToString("C");
        }

        private void Thu_Calculations(object sender, EventArgs e)
        {
            Weekday thursday = new Weekday(inputThurStartTimePicker.Value, inputThurFinishTimePicker.Value);
            resultThurHoursScheduled.Text = thursday.Duration.ToString(@"hh\:mm");
            resultThurBreaks.Text = thursday.Breaks.ToString(@"hh\:mm");
            resultThurGrossPay.Text = thursday.GrossPay.ToString("C");
        }

        private void Fri_Calculations(object sender, EventArgs e)
        {
            Weekday friday = new Weekday(inputFriStartTimePicker.Value, inputFriFinishTimePicker.Value);
            resultFriHoursScheduled.Text = friday.Duration.ToString(@"hh\:mm");
            resultFriBreaks.Text = friday.Breaks.ToString(@"hh\:mm");
            resultFriGrossPay.Text = friday.GrossPay.ToString("C");
        }

        private void Sat_Calculations(object sender, EventArgs e)
        {
            Weekday saturday = new Weekday(inputSatStartTimePicker.Value, inputSatFinishTimePicker.Value);
            resultSatHoursScheduled.Text = saturday.Duration.ToString(@"hh\:mm");
            resultSatBreaks.Text = saturday.Breaks.ToString(@"hh\:mm");
            resultSatGrossPay.Text = saturday.GrossPay.ToString("C");
        }

        private void Sun_Calculations(object sender, EventArgs e)
        {
            Weekday sunday = new Weekday(inputSunStartTimePicker.Value, inputSunFinishTimePicker.Value);
            resultSunHoursScheduled.Text = sunday.Duration.ToString(@"hh\:mm");
            resultSunBreaks.Text = sunday.Breaks.ToString(@"hh\:mm");
            resultSunGrossPay.Text = sunday.GrossPay.ToString("C");
        }

        private void Do_Calculations(object sender, EventArgs e)                                                    //runs when Calculate Hours button is clicked
        {
            //combine all amounts of gross pay

            //calculate tax by running method and return tax amount

            //calculate net pay using tax amount

            //display tax amount and net pay amount

        }
    }
}