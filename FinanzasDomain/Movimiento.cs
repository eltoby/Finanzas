using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanzasDomain
{
    [Table("Movimientos")]
    public class Movimiento
    {
        public int ID {get;set;}

        public string Concepto {get;set;}

        public decimal Importe {get;set;}
    }
}
