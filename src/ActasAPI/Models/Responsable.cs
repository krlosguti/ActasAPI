using System;
using System.ComponentModel.DataAnnotations;

namespace ActasAPI.Models
{
    public class Responsable
    {
        public int ResponsableId { get; set; }
        [StringLength(2)]
        public string Iniciales { get; set; }
        [MaxLength(50)]
        public string Nombres { get; set; }
        public bool Activo { get; set; } = true;
    }
}