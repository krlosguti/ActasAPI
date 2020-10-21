using System;
using System.ComponentModel.DataAnnotations;
using ActasAPI.Models;

namespace ActasAPI.Dtos
{
    public class CompromisoUpdateDto
    {
        public int ActaId { get; set; }
        public DateTime FechaEstimada { get; set; } = DateTime.Today;
        [MaxLength(250)]
        public string Descripcion { get; set; } = "";
        public EstadoCompromiso estadoCompromiso { get; set; } = EstadoCompromiso.AbiertoATiempo;
        //responsable
    }
}