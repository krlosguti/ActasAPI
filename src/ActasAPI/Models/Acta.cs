using System;

namespace ActasAPI.Models
{
    public class Acta
    {
        public int ActaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public String Temas { get; set; } = "Temas:";
        public String ResumenReunion { get; set; }
        public EstadoActa estadoActa { get; set; } = EstadoActa.Abierta;
        //public virtual ICollection<Asistente> asistentes { get; set; }
    }
}


