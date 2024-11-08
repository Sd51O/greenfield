using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Taxation;
using Penalty;


namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operation op1 = new Operation(Handler.PayServiceTax);
             Operation op2 = new Operation(Handler.PayIncomeTax);
             Operation op3 = new Operation(Handler.PayGSTTax);
             Operation masterOperation = null;
             masterOperation += op1;
             masterOperation += op2;
             masterOperation += op3;
             masterOperation.Invoke(30);*/

            //object creation

            Account acct = new Account(5000);
            
            //event registration
            acct.underBalance += PenaltyHandler.ServiceDisconnectionPenaltyCharges;
            acct.underBalance += PenaltyHandler.NoticationPenalty;

            //object invokation
            acct.Withdraw(8000);

            acct.overBalance += TaxHandler.PayIncomeTax;
            acct.overBalance += TaxHandler.PayProfessionalTax;
            acct.Deposit(500000);
            Console.ReadLine();

        }
    }
}
