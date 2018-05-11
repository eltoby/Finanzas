namespace FinanzasDomain
{
    using System;

    public class Movimiento
    {
        public int ID {get;set;}

        public DateTime Fecha { get; set; }

        public string Concepto {get;set;}

        public decimal Importe {get;set;}
    }
}
