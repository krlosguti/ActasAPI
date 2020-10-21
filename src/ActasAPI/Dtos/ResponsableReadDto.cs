using System;
using ActasAPI.Models;

namespace ActasAPI.Dtos
{
    public class ResponsableReadDto
    {
        public int ResponsableId { get; set; }
        public string Iniciales { get; set; }
        public string Nombres { get; set; }
        public bool Activo { get; set; } = true;
    }
}