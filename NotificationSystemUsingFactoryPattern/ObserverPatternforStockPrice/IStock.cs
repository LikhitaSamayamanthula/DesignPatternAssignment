using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternforStockPrice
{
    public interface IStock
    {
        void RegisterInvestor(IInvestor investor);
        void RemoveInvestor(IInvestor investor);
        void NotifyInvestors();
        void UpdateStockPrice(double newPrice);
    }
}
