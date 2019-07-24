using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial6.Controllers
{
    [Route("api/[controller]")]
    public class MarketDataController : Controller
    {
        private readonly ASXAuditTrailContext db;
        public MarketDataController(ASXAuditTrailContext sc)
        {
            db = sc;
        }

        // GET api/<controller>/
        [HttpGet("{code}/{offset}/{rows}")]
        public List<MarketChartPrice> Get(string code, int offset, int rows)
        {
            return db.GetMarketChartPricesAsync(code, offset, rows);
        }
    }
}
