using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrades.Models;
using MySql.Data.MySqlClient;

namespace StockTrades.DataSource
{
    public class TradeAccessor{
        protected string ConnectionString;

        public TradeAccessor(){
            ConnectionString = String.Format("SERVER={0}; PORT={1}; DATABASE={2}; UID={3}; PASSWORD={4}",
                "127.0.0.1","3306","StockTrades", "root", "pass");     
        }

        
        public Trade insert(Trade model)
        {
            var query = String.Format(
                "INSERT INTO {0} ( ticker, quantity,date_buy,buy_price) VALUES ({1}, {2}, {3}, {4});",
                "", model.Ticker, model.Quantity, model.BuyDate, model.BuyPrice
            );

            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                var lastInsertedId = cmd.LastInsertedId;
                model.Id = (int)lastInsertedId;
            }

            return model;
        }

        /*public override TradeModel get(Trade trade)
        {

            // FIX whatever this is
            string format = "yyyy-MM-dd";
            string date = String.Format("'{0}': {1}", format, trade.Date.ToString(format));
  
            return trade;
        }*/
    }
}
