using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZCompany.Trading.AssetTradingLibrary
{
    //There could be some buying startegies like buiyng pure gold, BIS, Hallmark etc, for now 
    // I dont have details or domain info
    public class BuyingStrategy: Strategy
    {
       public override double DetermineProfit(double Gram, double Price, DateTime Transaction, out bool Profit, List<Asset> CurrentAsset)
        {
            return this.Calculate(Gram,Price,Transaction,out Profit,CurrentAsset);
        }
       
    }
}
