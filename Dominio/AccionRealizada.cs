namespace CentroMedico.Dominio
{
    public class AccionRealizada
    {
        public string Tipo { get; set; } // "Registrar", "Atender", "Eliminar", etc.
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }

        public AccionRealizada(string tipo, string descripcion)
        {
            Tipo = tipo;
            Descripcion = descripcion;
            FechaHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{FechaHora:HH:mm}] {Tipo}: {Descripcion}";
        }
    }

}
