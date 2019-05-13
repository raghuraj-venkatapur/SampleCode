using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZCompany.Trading.AssetTradingLibrary
{
   public abstract class Strategy
    {
        protected double GetAveragePrice(List<Asset> CurrentAsset)
        {
            double totalGram = CurrentAsset.Sum(m => m.Gram);
            double totalPrice = CurrentAsset.Sum(m => m.Price);

            return (totalPrice / totalGram);
        }

        protected virtual double Calculate(double Gram, double Price, DateTime Transaction, out bool Profit, List<Asset> CurrentAsset)
        {
            //Get Avg Price per gram
            double avgPrice = GetAveragePrice(CurrentAsset);
            double currAvgPrice = Price / Gram;
            //This is Profit
            if (currAvgPrice > avgPrice)
            {
                Profit = true;
                return ((currAvgPrice - avgPrice) * Gram);

            }
            //This is Loss
            else
            {
                Profit = false;
                return ((avgPrice - (currAvgPrice)) * Gram);
            }

        }

        public abstract double DetermineProfit(double Gram, double Price, DateTime Transaction, out bool Profit, List<Asset> CurrentAsset);
    }
}
