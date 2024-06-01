using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Calculator
{
    internal static class Payment
    {
        

/*        public static double CalculateTax(double grossPay)
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
                    {
                        CalculateNetPay(grossPay, tax);
                        resultTaxAmount.Text = tax.ToString("C");
                        return tax;
                    }
                }
            }
            return 0;
        }

        public static double CalculateNetPay(double grossPay, double taxAmount)
        {
            double netPay = grossPay - taxAmount;
            resultNetPay.Text = netPay.ToString("C");
            return netPay;
        }*/
    }
}
