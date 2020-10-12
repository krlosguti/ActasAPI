using System;
using System.ComponentModel.DataAnnotations;

namespace ActasAPI.Models
{
    public class Compromiso
    {
        public int CompromisoId { get; set; }
        public int ActaId { get; set; }
        public DateTime FechaEstimada { get; set; } = DateTime.Today;
        [MaxLength(250)]
        public string Descripcion { get; set; } = "";
        public EstadoCompromiso estadoCompromiso { get; set; } = EstadoCompromiso.AbiertoATiempo;
        //responsable
    }
}