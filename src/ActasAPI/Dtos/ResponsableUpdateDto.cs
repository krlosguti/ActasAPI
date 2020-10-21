using System;
using System.ComponentModel.DataAnnotations;
using ActasAPI.Models;

namespace ActasAPI.Dtos
{
    public class ResponsableUpdateDto
    {
        [StringLength(2)]
        public string Iniciales { get; set; }
        [MaxLength(50)]
        public string Nombres { get; set; }
        public bool Activo { get; set; } = true;
    }
}