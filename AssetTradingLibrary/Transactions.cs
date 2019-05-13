using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZCompany.Trading.AssetTradingLibrary
{
    /// <summary>
    /// this data would ideally be a data stored
    /// </summary>
   public class Transactions
    {
        //One txn one Asset, One Buying or Selling Date
       public Asset Asset { get; set; }

        public DateTime TxnDate { get; set; }

        //True if buying
        public bool Buying { get; set; }
       
    }
}
