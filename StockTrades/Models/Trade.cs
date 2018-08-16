using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTrades.Models
{
    public class Trade
    {

        private String Ticker { get; set; }
        private Decimal BuyPrice { get; set; }
        private Decimal SellPrice { get; set; }
        private Decimal TargetPrice { get; set; }
        private Decimal StopPrice { get; set; }
        


        public Trade (String ticker, Decimal buyPrice, Decimal sellPrice, Decimal targetPrice, Decimal stopPrice)
        {
            Ticker = ticker;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            TargetPrice = targetPrice;
            StopPrice = stopPrice;
        }

    }
}