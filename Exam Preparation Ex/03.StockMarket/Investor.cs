using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
       public Investor(string fullName,string emailAdress,decimal moneyToInvest,string brokerName)
        {
            portfoilio = new List<Stock>();
            this.FullName = fullName;
            this.EmailAddress = emailAdress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
        }


        List<Stock> portfoilio;
        public string FullName { get; set; }
        public string EmailAddress { get; set; }

        public decimal MoneyToInvest { get; set; }

        public string BrokerName { get; set; }

        public int Count => this.Portfolio.Count;

        public List<Stock> Portfolio { get => Portfolio; set => Portfolio = value; }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.Portfolio.Add(stock);
                MoneyToInvest -= stock.MarketCapitalization;
             }
        }

        public string SellStock(string companyName,decimal sellPrice)
        {
            
            //foreach(Stock stock in this.Portfolio)
            //{
            //    if(stock.CompanyName==companyName && stock.MarketCapitalization == sellPrice)
            //    {
            //        if (stock.MarketCapitalization < stock.PricePerShare)
            //        {

            //            return "Cannot sell {companyName}.";
            //        }
            //        else
            //        {
            //            this.portfoilio.Remove(stock);
            //            MoneyToInvest+=stock.MarketCapitalization;
            //            return $"{companyName} was sold.";
            //        }
            //    }
            //}
            //return "{companyName} does not exist.";

            var findCompany = Portfolio.Find(x => x.CompanyName == companyName);
            if (findCompany.Equals(null))
            {
                return "{companyName} does not exist.";
            }
            if(sellPrice < findCompany.PricePerShare)
            {
                return "Cannot sell {companyName}.";
            }
            this.Portfolio.RemoveAll(x => x.CompanyName == companyName);
            this.MoneyToInvest-=sellPrice;
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
        {
            var stock = portfoilio.Find(x => x.CompanyName == companyName);
            if (stock != null)
            {
                return stock;
            }
            return null;
        }

        public Stock FindBiggestCompany()
        {
            var stock = portfoilio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
            if (stock == null)
            {
                return null;
            }
            return stock;
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks");
            foreach(var stock in Portfolio)
            {
                sb.AppendLine(stock.ToString());
            }
            return sb.ToString();
        }
    }
}
