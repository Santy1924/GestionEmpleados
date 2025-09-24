namespace GestionEmpleados.Models
{
    public abstract class Persona
    {
        protected Guid Id { get; private set; } = Guid.NewGuid();
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte Edad { get; set; }

        protected Persona(string nombre, string apellido, byte edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public abstract void MostrarInformacion();
    }
}