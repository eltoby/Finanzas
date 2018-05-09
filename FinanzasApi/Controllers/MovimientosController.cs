using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinanzasDtos;

namespace FinanzasApi.Controllers
{
    [Route("api/[controller]")]
    public class MovimientosController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"true"};
        }
    
        [HttpPost, Route("Insert")]
        public bool Insert([FromBody]MovimientoDto movimiento)
        {
            return true;
        }
    }
}
