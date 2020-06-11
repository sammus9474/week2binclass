using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    public class AutoLoan:LoanInfo
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public string CarAmt { get; set; }

        public override string ToString()
        {
            return base.ToString()+string.Format("Year: {0}\n"+
                                                 "Make: {1}\n"+
                                                 "Model: {2}\n"+
                                                 "VIN: {3}\n"+
                                                 "Total Amount Borrowed for Car: {4}\n",Year,Make,Model,VIN,CarAmt);
        }
    }
}
