using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _2ndTest.Models
{
    public class Stock
    {
        [Display(Name = "股票代號")]
        public string StockId { get; set; }
        [Display(Name = "股票名稱")]
        public string StockName { get; set; }
        [Display(Name = "昨收盤價")]
        public double PreviousClose { get; set; }
        [Display(Name = "開盤價")]
        public double openingPrice { get; set; }
        [Display(Name = "最高價")]
        public double highestPrice { get; set; }
        [Display(Name = "最低價")]
        public double lowestPrice { get; set; }
        [Display(Name = "收盤價")]
        public double closingPrice { get; set; }
        [Display(Name = "漲跌價")]
        public double change { get; set; }
        [Display(Name = "漲跌幅%")]
        public double ROC { get; set; }

    }
}