using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BankAccount
{
    class BankAccount
    {
        private String holder1Name = "Ivan";
        private String holder2Name = "Petrov";
        private String holder3Name = "Ivanov";
        private decimal moneyAmount = 345.3m;
        private String bankName = "CQS";
        private String IBAN = "BG12SOME5";
        private String BIC = "BIC02";
        private ulong CCNumberA = 1234234534564567;
        private ulong CCNumberB = 1234234534564568;
        private ulong CCNumberC = 1234234534564569; 

        static void Main(string[] args)
        {
           BankAccount Account = new BankAccount();
           System.Console.WriteLine(Account.holder1Name);
           System.Console.WriteLine(Account.holder2Name);
           System.Console.WriteLine(Account.holder3Name);
           System.Console.WriteLine(Account.bankName);
           System.Console.WriteLine(Account.IBAN);
           System.Console.WriteLine(Account.BIC);
           System.Console.WriteLine(Account.CCNumberA);
           System.Console.WriteLine(Account.CCNumberB);
           System.Console.WriteLine(Account.CCNumberC);
        }
    }
}
