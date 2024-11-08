using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    public delegate void Operation(float factor);       //object oriented function pointer
    public static class TaxHandler
    {
       
        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income tax" +factor+" deducted from your account");
       }

        public static void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Professional tax" +factor+" deducted from your account");
        }

        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service tax " +factor+" deducted from your account");
        }

        public static void PayGSTTax(float factor)
        {
            Console.WriteLine("GST tax " +factor+" deducted from your account");
        }
    }
}
    public static class PenaltyHandler
{
    public static void ServiceDisconnectionPenaltyCharges(float amount) 
    {
        Console.WriteLine("Disconnection charges applied =" + amount);
    }

    public static void NoticationPenalty(float amount)
    {
        Console.WriteLine("Notification Charges Applied=" + amount);
    }
}