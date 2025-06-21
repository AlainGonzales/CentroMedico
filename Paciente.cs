namespace CentroMedico
{
    public class Paciente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Sintomas { get; set; }

        public Paciente(string dni, string nombre, string edad, string sintomas)
        {
            DNI = dni;
            Nombre = nombre;
            Edad = edad;
            Sintomas = sintomas;
        }

        public override string ToString()
        {
            return $"{Nombre} ({DNI})";
        }
    }
}
