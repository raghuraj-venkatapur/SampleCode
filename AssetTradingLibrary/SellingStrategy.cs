using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZCompany.Trading.AssetTradingLibrary
{
    /// <summary>
    /// This may include other child strategies such as Festival Startegy, Auspisous Startegy,
    /// Adhoc Startegy to determine best seeling date and price etc..
    /// </summary>
   public class SellingStrategy : Strategy
    {
        public override double DetermineProfit(double Gram, double Price, DateTime Transaction, out bool Profit, List<Asset> CurrentAsset)
        {
            return this.Calculate(Gram, Price, Transaction, out Profit, CurrentAsset);
        }

    }
}
