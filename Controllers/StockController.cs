using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace vrgoserver.Models 
{
    [Route("vrgoserver/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            Stock stock = new Stock();
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(stock);
            return Ok(str);
        }
    }
}