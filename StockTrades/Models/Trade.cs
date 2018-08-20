using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTrades.Models
{
    public class Trade
    {

        //check all params 
        public int Id { get; set; }
        public String Ticker { get; set; }
        public int Quantity { get; set; }
        public DateTime BuyDate { get; set; }
        public Decimal BuyPrice { get; set; }
        public Decimal SellPrice { get; set; }
        public Decimal TargetPrice { get; set; }
        public Decimal StopPrice { get; set; }
        


        public Trade (String ticker, int quantity, DateTime buyDate, Decimal buyPrice)//fix params
        {
            //Id = id;
            Ticker = ticker;
            Quantity = quantity;
            BuyDate = buyDate;
            BuyPrice = buyPrice;
            //SellPrice = sellPrice;
            //TargetPrice = targetPrice;
            //StopPrice = stopPrice;
        }

    }
}