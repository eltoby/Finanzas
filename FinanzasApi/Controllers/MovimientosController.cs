using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinanzasDtos;
using FinanzasEF;
using FinanzasDomain;

namespace FinanzasApi.Controllers
{
    [Route("api/[controller]")]
    public class MovimientosController : Controller
    {
        private readonly FinanzasContext context;

        public MovimientosController(FinanzasContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"true"};
        }
    
        [HttpPost, Route("Insert")]
        public bool Insert([FromBody]Movimiento movimiento)
        {
            this.context.Add(movimiento);
            this.context.SaveChanges();
            return true;
        }
    }
}
