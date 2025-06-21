namespace CentroMedico
{
    public class NodoMedico
    {
        public Medico Valor { get; set; }
        public NodoMedico Siguiente { get; set; }

        public NodoMedico(Medico medico)
        {
            Valor = medico;
            Siguiente = null;
        }
    }

}
