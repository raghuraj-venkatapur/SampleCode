using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZCompany.Trading.AssetTradingLibrary
{
    /// <summary>
    /// An Asset can be sold or purchased
    /// </summary>
    public class Asset
    {
        public String  Name { get; set; }
        
        public double Price
        {
            get;set;

        }

        public double Gram
        {
            get; set;

        }

       

    }
}