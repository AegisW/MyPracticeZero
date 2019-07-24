using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial6.Models;

namespace Tutorial6.ViewModels
{
    public class Home
    {
        public string SecCode { get; set; }
        public int OffsetCount { get; set; }
        public int RowCount { get; set; }
        public List<MarketChartPrice> MarketChartPrice { get; set; }
    }
}
