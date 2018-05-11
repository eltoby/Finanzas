namespace FinanzasDtos
{
    using System;

    public class MovimientoDto
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Concepto { get; set; }

        public decimal Importe { get; set; }
    }
}