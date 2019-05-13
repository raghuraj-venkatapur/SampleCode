using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XYZCompany.Trading.AssetTradingLibrary;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DetermineMargin()
        {
            Customer customer = new Customer();
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
            Assert.AreEqual(margin, 0);
        }

        [TestMethod]
        public void DetermineIsProfit()
        {
            Customer customer = new Customer();
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
            Assert.AreEqual(profit, false);
        }
    }
}
