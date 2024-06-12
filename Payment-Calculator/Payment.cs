using System;

namespace Payment_Calculator
{
    internal static class Payment
    {
        public static double CalculateTax(double grossPay)
        {
            double[] taxLookupAmt = { 0, 359, 438, 548, 721, 865, 1282, 2307, 3461 };
            double[] taxLookupA = { 0.0000, 0.1900, 0.2900, 0.2100, 0.2190, 0.3477, 0.3450, 0.3900, 0.4700 };
            double[] taxLookupB = { 0.0000, 68.3462, 112.1942, 68.3465, 74.8369, 186.2119, 182.7504, 286.5965, 563.5196 };

            for (int i = 0; i < taxLookupAmt.Length; i++)
            {
                if (grossPay <= taxLookupAmt[i])
                {
                    return 0;
                }
                if (grossPay < taxLookupAmt[i])
                {
                    return (Math.Floor(grossPay) * taxLookupA[i] - taxLookupB[i]);
                }
            }

            return grossPay * taxLookupA[^1] - taxLookupB[^1]; // For grossPay greater than the highest tax slab
        }

        public static double CalculateNetPay(double grossPay, double taxAmount)
        {
            return grossPay - taxAmount;
        }
    }
}
