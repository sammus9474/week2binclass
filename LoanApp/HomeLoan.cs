using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    public class HomeLoan:LoanInfo
    {
        public string TypeOfConstruct { get; set; }
        public string YrBuilt { get; set; }
        public string SqFt { get; set; }
        public string HomeAmt { get; set; }

        public override string ToString()
        {
            return base.ToString()+string.Format("Type of Construction: {0}\n"+
                                                 "Year House was Built: {1}\n"+
                                                 "Square Feet of Home: {2}\n"+
                                                 "Total Amount Borrowed for Home: {3}\n",TypeOfConstruct,YrBuilt,SqFt,HomeAmt);
        }
    }
}
