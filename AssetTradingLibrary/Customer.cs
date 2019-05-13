using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZCompany.Trading.AssetTradingLibrary
{
    /// <summary>
    /// one customer has many assets
    /// </summary>
    public class Customer
    {
        public List<Asset> Assets { get; set; }
        public String Name { get; set; }
    }
}
