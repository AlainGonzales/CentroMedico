namespace CentroMedico
{
    public class NodoAccion
    {
        public AccionRealizada Valor { get; set; }
        public NodoAccion Siguiente { get; set; }

        public NodoAccion(AccionRealizada accion)
        {
            Valor = accion;
            Siguiente = null;
        }
    }

}
