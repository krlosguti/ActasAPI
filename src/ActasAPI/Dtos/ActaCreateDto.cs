using System;
using System.ComponentModel.DataAnnotations;
using ActasAPI.Models;

namespace ActasAPI.Dtos
{
    public class ActaCreateDto
    {
        public DateTime Fecha { get; set; } = DateTime.Today;
        [MaxLength(250)]
        public String Temas { get; set; } = "Temas:";
        [MaxLength(250)]
        public String ResumenReunion { get; set; }
        public EstadoActa estadoActa { get; set; } = EstadoActa.Abierta;
        //public virtual ICollection<Asistente> asistentes { get; set; }
    }
}