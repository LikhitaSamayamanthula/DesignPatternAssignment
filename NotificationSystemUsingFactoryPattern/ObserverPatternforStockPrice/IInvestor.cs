using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternforStockPrice
{
    public interface IInvestor
    {
        void Update(string stockName, double stockPrice);
    }

}
