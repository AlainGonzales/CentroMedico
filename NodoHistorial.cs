namespace CentroMedico
{
    public class NodoHistorial
    {
        public AtencionMedica Valor { get; set; }
        public NodoHistorial Siguiente { get; set; }
        public NodoHistorial Anterior { get; set; }

        public NodoHistorial(AtencionMedica atencion)
        {
            this.Valor = atencion;
            this.Siguiente = null;
            this.Anterior = null;
        }
    }
}
