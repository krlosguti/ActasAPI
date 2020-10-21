using System;
using ActasAPI.Models;

namespace ActasAPI.Dtos
{
    public class CompromisoReadDto
    {
        public int CompromisoId { get; set; }
        public int ActaId { get; set; }
        public DateTime FechaEstimada { get; set; } = DateTime.Today;
        public string Descripcion { get; set; } = "";
        public EstadoCompromiso estadoCompromiso { get; set; } = EstadoCompromiso.AbiertoATiempo;
        //responsable
    }
}