using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    public class LoanInfo
    {
        public string CustName { get; set; }
        public string LoanNum { get; set; }
        public string LoanAmt { get; set; }

        public override string ToString()
        {
            return string.Format("Customer Name: {0}\n" +
                                 "Loan Number: {1}\n" +
                                 "Loan Amount: {2}\n",CustName,LoanNum,LoanAmt);
        }

    }
}
