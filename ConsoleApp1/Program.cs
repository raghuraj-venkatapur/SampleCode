using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZCompany.Trading.AssetTradingLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Raghuraj";

            //Current Assets of customer, this should ideally be pulled from txns and db

            Asset asset = new Asset();
            asset.Name = "Gold";
            asset.Gram = 100.00;
            //not real, avg price
            asset.Price = 3500.00;

            List<Asset> assets = new List<Asset>();
            assets.Add(asset);

            customer.Assets = assets;

            SellingStrategy selling = new SellingStrategy();
            bool profit = false;
            DateTime txnDate = Convert.ToDateTime("02-01-2019");
            double margin = selling.DetermineProfit(100, 3500, txnDate, out profit, assets);

            if (profit)
            {
                Console.WriteLine(" Yes you make Profit of " + margin.ToString());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" No Dont Sell you make Loss of " + margin.ToString());
                Console.ReadLine();
            }

        }
    }
}
