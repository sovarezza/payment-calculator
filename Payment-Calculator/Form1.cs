using System;
using System.Windows.Forms;

namespace Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double combinedGrossPay, oldGrossPay = 0, oldTaxAmount = 0, oldNetPay = 0;

        private void Day_Calculations(DateTime startTime, DateTime endTime, Label hoursScheduled, Label breaks, Label grossPay)
        {
            Weekday weekday = new Weekday(startTime, endTime);
            hoursScheduled.Text = weekday.Duration.ToString(@"hh\:mm");
            breaks.Text = weekday.Breaks.ToString(@"hh\:mm");
            grossPay.Text = weekday.GrossPay.ToString("C");
            combinedGrossPay += weekday.GrossPay;
        }

        private void Mon_Calculations(object sender, EventArgs e) => Day_Calculations(inputMonStartTimePicker.Value, inputMonFinishTimePicker.Value, resultMonHoursScheduled, resultMonBreaks, resultMonGrossPay);
        private void Tue_Calculations(object sender, EventArgs e) => Day_Calculations(inputTueStartTimePicker.Value, inputTueFinishTimePicker.Value, resultTueHoursScheduled, resultTueBreaks, resultTueGrossPay);
        private void Wed_Calculations(object sender, EventArgs e) => Day_Calculations(inputWedStartTimePicker.Value, inputWedFinishTimePicker.Value, resultWedHoursScheduled, resultWedBreaks, resultWedGrossPay);
        private void Thu_Calculations(object sender, EventArgs e) => Day_Calculations(inputThurStartTimePicker.Value, inputThurFinishTimePicker.Value, resultThurHoursScheduled, resultThurBreaks, resultThurGrossPay);
        private void Fri_Calculations(object sender, EventArgs e) => Day_Calculations(inputFriStartTimePicker.Value, inputFriFinishTimePicker.Value, resultFriHoursScheduled, resultFriBreaks, resultFriGrossPay);
        private void Sat_Calculations(object sender, EventArgs e) => Day_Calculations(inputSatStartTimePicker.Value, inputSatFinishTimePicker.Value, resultSatHoursScheduled, resultSatBreaks, resultSatGrossPay);
        private void Sun_Calculations(object sender, EventArgs e) => Day_Calculations(inputSunStartTimePicker.Value, inputSunFinishTimePicker.Value, resultSunHoursScheduled, resultSunBreaks, resultSunGrossPay);

        private void Do_Calculations(object sender, EventArgs e)
        {
            if (combinedGrossPay != oldGrossPay)
            {
                double taxAmount = Payment.CalculateTax(combinedGrossPay);
                double netPay = Payment.CalculateNetPay(combinedGrossPay, taxAmount);

                resultTaxAmount.Text = taxAmount.ToString("C");
                resultNetPay.Text = netPay.ToString("C");

                oldGrossPay = combinedGrossPay;
                oldTaxAmount = taxAmount;
                oldNetPay = netPay;
            }
            else
            {
                resultTaxAmount.Text = oldTaxAmount.ToString("C");
                resultNetPay.Text = oldNetPay.ToString("C");
            }
        }
    }
}
