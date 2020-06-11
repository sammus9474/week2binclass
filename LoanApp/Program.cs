using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanInfo info = new LoanInfo();
            info.CustName = "Courtnee & Emi";
            info.LoanNum = "456789123";
            info.LoanAmt = "452000";

            Console.WriteLine(info);

            AutoLoan auto = new AutoLoan();
            auto.Make = "Pathfinder";
            auto.Model = "Nissan";
            auto.Year = "2013";
            auto.VIN = "12345678912345";
            auto.CarAmt = "32000";

            Console.WriteLine(auto);

            HomeLoan home = new HomeLoan();
            home.TypeOfConstruct = "Stucco";
            home.YrBuilt = "2013";
            home.SqFt = "3600";
            home.HomeAmt = "420000";

            Console.WriteLine(home);
        }
    }
}
