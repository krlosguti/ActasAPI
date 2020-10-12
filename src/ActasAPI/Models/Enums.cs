namespace ActasAPI.Models
{
    public enum EstadoActa{
        Abierta,
        Cerrada
    }

    public enum TipoAvance{
        Seguimiento,
        Cierre
    }

    public enum EstadoCompromiso
    {
        AbiertoATiempo,
        AbiertoAtrasado,
        CerradoATiempo,
        CerradoAtrasado
    }
    public enum EstadoResponsable
    {
        Activo,
        Inactivo
    }
}