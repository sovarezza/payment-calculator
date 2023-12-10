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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calculateHoursbutton1_Click(object sender, EventArgs e)
        {
        }

        private void do_Calculations(object sender, EventArgs e)
        {
            ScheduledHours(inputMonStartTimePicker.Value.ToString(), inputMonFinishTimePicker.Value.ToString());
        }

        private TimeSpan ScheduledHours(string startTime, string finishTime)
        {
            TimeSpan duration = DateTime.Parse(finishTime).Subtract(DateTime.Parse(startTime));
            resultMonHoursScheduled.Text = duration.ToString(@"hh\:mm");
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

        private double CalculateGrossPay(TimeSpan duration, TimeSpan breaks)
        {
            //convert duration into double
            double scheduledHours = duration.TotalHours;

            //convert breaks into double
            double mealBreaks = breaks.TotalHours;

            //subtract breaks from duration
            double totalHours = scheduledHours - mealBreaks;

            //multiply pay amount by hours worked for gross total
            double payAmount = 25.27490;
            double grossPay = totalHours * payAmount;

            //display gross amount
            resultMonGrossPay.Text = grossPay.ToString("C");

            CalculateTax(grossPay);
            //CalculateNetPay(grossPay, 0);

            //return gross amount
            return grossPay;
        }

        private double CalculateTax(double grossPay)
        {
            #region Tax Lookup Arrays   
            double[] taxLookupAmt = new double[9] { 0, 359, 438, 548, 721, 865, 1282, 2307, 3461 }; //ATO tax amounts to compare gross pay to
            double[] taxLookupA = new double[9] { 0.0000, 0.1900, 0.2900, 0.2100, 0.2190, 0.3477, 0.3450, 0.3900, 0.4700 }; //number to multiply gross pay by
            double[] taxLookupB = new double[9] { 0.0000, 68.3462, 112.1942, 68.3465, 74.8369, 186.2119, 182.7504, 286.5965, 563.5196 }; //amount to minus from inital calculation to determine tax amount
            #endregion

            for (int i = 0; i < taxLookupAmt.Length; i++)
            {
                if (grossPay <= taxLookupAmt[0] || (grossPay > taxLookupAmt[0] && grossPay < taxLookupAmt[1]))
                {
                    resultTaxAmount.Text = 0.ToString("C");
                    double tax = 0;
                    CalculateNetPay(grossPay, tax);
                    return 0;
                }
                else if (taxLookupAmt[i] > grossPay)
                {
                    double tax = (Math.Floor((Math.Truncate(grossPay))) * taxLookupA[i] - taxLookupB[i]);

                    /*                    if (tax < 1) //here to ensure that if tax amount calculation is a negative number, will return nothing
                                        {
                                            taxLabel2.Text = "$0.00";
                                            CalculateNetPay(grossPay, tax);
                                            return 0;
                                        }
                                        else*/
                    {
                        CalculateNetPay(grossPay, tax);
                        resultTaxAmount.Text = tax.ToString("C");
                        return tax;
                    }
                }
            }
            return 0;
        }

        private double CalculateNetPay(double grossPay, double taxAmount)
        {
            double netPay = grossPay - taxAmount;
            resultNetPay.Text = netPay.ToString("C");
            return netPay;
        }
    }
}