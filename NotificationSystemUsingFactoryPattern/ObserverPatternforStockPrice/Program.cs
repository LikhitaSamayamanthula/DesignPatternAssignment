namespace ObserverPatternforStockPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("ABC Corp", 150.00);
            Investor investor1 = new Investor("Alice");
            Investor investor2 = new Investor("Bob");

            stock.RegisterInvestor(investor1);
            stock.RegisterInvestor(investor2);

            stock.UpdateStockPrice(155.75);

            stock.RemoveInvestor(investor1);

            stock.UpdateStockPrice(160.50);
        }
    }
}
