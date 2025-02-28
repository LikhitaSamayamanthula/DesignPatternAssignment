using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternforStockPrice
{
    public class Stock : IStock
    {
        private List<IInvestor> investors = new List<IInvestor>();
        private string StockName { get; set; }
        private double StockPrice { get; set; }

        public Stock(string stockName, double stockPrice)
        {
            StockName = stockName;
            StockPrice = stockPrice;
        }

        public void UpdateStockPrice(double newPrice)
        {
            StockPrice = newPrice;
            Console.WriteLine($"Stock price of {StockName} updated to {StockPrice}.");
            NotifyInvestors();
        }

        public void RegisterInvestor(IInvestor investor)
        {
            investors.Add(investor);
            Console.WriteLine("Investor added.");
        }

        public void RemoveInvestor(IInvestor investor)
        {
            investors.Remove(investor);
            Console.WriteLine("Investor removed.");
        }

        public void NotifyInvestors()
        {
            foreach (var investor in investors)
            {
                investor.Update(StockName, StockPrice);
            }
        }
    }
}