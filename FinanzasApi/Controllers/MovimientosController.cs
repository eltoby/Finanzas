using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinanzasDtos;
using FinanzasEF;
using FinanzasDomain;
using AutoMapper;

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
        public IEnumerable<MovimientoDto> Get()
        {
            var result = this.context.Movimientos.ToArray();
            var dtos = Mapper.Map<IEnumerable<MovimientoDto>>(result);
            return dtos;
        }
    
        [HttpPost, Route("Insert")]
        public bool Insert([FromBody]MovimientoDto dto)
        {
            var movimiento = Mapper.Map<Movimiento>(dto);
            this.context.Add(movimiento);
            this.context.SaveChanges();
            return true;
        }

        [HttpPost, Route("Last")]
        public IEnumerable<MovimientoDto> Last(int cantidad)
        {
            var movimientos = this.context.Movimientos.OrderByDescending(x => x.Fecha).Take(cantidad);
            var dtos = Mapper.Map<IEnumerable<MovimientoDto>>(movimientos);
            return dtos;
        }
    }
}
