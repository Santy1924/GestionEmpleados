namespace GestionEmpleados.Models
{
    public abstract class Persona
    {
        protected Guid Id { get; private set; } = Guid.NewGuid();
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected byte Edad { get; set; }

        protected Persona(string nombre, string apellido, byte edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public abstract void MostrarInformacion();
    }
}