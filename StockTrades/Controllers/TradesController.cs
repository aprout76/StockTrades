using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockTrades.DataSource;
using StockTrades.Models;

namespace StockTrades.Controllers
{
    public class TradesController : Controller
    {
        // GET: Trades
        public ActionResult Index()
        {
            return View();
        }

        #region Post Actions
        public ActionResult create(String ticker, int quantity, String date_buy, decimal price_buy)
        {
            Trade newTrade = new Trade(ticker, quantity, date_buy, price_buy);
            TradeAccessor tradeDB = new TradeAccessor();

            tradeDB.insert(newTrade);

            return RedirectToAction("Trades");
        }

        #endregion
    }
}