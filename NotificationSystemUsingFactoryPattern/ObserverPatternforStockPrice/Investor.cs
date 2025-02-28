using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternforStockPrice
{
    public class Investor : IInvestor
    {
        private string InvestorName;

        public Investor(string investorName)
        {
            InvestorName = investorName;
        }

        public void Update(string stockName, double stockPrice)
        {
            Console.WriteLine($"Hello {InvestorName}, the stock {stockName} is now priced at {stockPrice}.");
        }
    }
}
