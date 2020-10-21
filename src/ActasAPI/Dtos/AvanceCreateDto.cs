using System;
using System.ComponentModel.DataAnnotations;
using ActasAPI.Models;

namespace ActasAPI.Dtos
{
    public class AvanceCreateDto
    {
        public int CompromisoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        [MaxLength(250)]
        public string ActividadesRealizadas { get; set; } = "Avance: ";
        public TipoAvance tipoAvance { get; set; } = TipoAvance.Seguimiento;
    }
}