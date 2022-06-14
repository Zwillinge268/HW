using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2ndTest.Models;


namespace _2ndTest.Controllers
{
    public class StockController : Controller
    {
        protected List<Stock> stocks = new List<Stock>
        {
            new Stock { StockId = "2330", StockName = "臺積電", PreviousClose = 520, openingPrice = 522, highestPrice = 529, lowestPrice = 520, closingPrice = 524},
            new Stock { StockId = "1650", StockName = "華新", PreviousClose = 57, openingPrice = 60, highestPrice = 61, lowestPrice = 51.3, closingPrice = 51.3},
            new Stock { StockId = "1533", StockName = "車王店", PreviousClose = 62.9, openingPrice = 61.5, highestPrice = 62.9, lowestPrice = 60.4, closingPrice = 62.1},
            new Stock { StockId = "1303", StockName = "南亞", PreviousClose = 92.5, openingPrice = 93, highestPrice = 94.5, lowestPrice = 91.2, closingPrice = 92.5},
            new Stock { StockId = "4915", StockName = "致伸", PreviousClose = 71, openingPrice = 77, highestPrice = 78.1, lowestPrice = 76.5, closingPrice = 78.1},
            new Stock { StockId = "2881", StockName = "富邦金", PreviousClose = 82.4, openingPrice = 80.5, highestPrice = 84.8, lowestPrice = 79.8, closingPrice = 82.4},
            new Stock { StockId = "2454", StockName = "聯發科", PreviousClose = 875, openingPrice = 890, highestPrice = 900, lowestPrice = 875, closingPrice = 880}
        };

        public ActionResult Index()
        {
            return View(stocks);
        }
        public ActionResult ShowChange()
        {
            foreach(var stock in stocks)
            {
                stock.change = Math.Round(stock.closingPrice - stock.PreviousClose,1);
                stock.ROC = Math.Round(stock.change / stock.PreviousClose*100,2);
            }
            return View(stocks);
        }
    }
}