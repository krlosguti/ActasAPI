using System;

namespace ActasAPI.Models
{
    public class Avance
    {
        public int AvanceId { get; set; }
        public int CompromisoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public string ActividadesRealizadas { get; set; } = "Avance: ";
        public TipoAvance tipoAvance { get; set; } = TipoAvance.Seguimiento;
    }
}