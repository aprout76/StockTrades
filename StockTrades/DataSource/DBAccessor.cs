using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrades.DataSource
{
    public class TradeAccessor{
        protected string ConnectionString;

        protected TradeAccessor(){
            ConnectionString = String.Format("SERVER={0}; PORT={1}; DATABASE={2}; UID={3}; PASSWORD={4}",
                "127.0.0.1","3306","StockTrades", "root", "pass");     
        }

        

    }
}
