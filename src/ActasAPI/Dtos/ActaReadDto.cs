using System;
using ActasAPI.Models;


namespace ActasAPI.Dtos
{
    public class ActaReadDto
    {
        public int ActaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public String Temas { get; set; } = "Temas:";
        public String ResumenReunion { get; set; }
        public EstadoActa estadoActa { get; set; } = EstadoActa.Abierta;
    }
}