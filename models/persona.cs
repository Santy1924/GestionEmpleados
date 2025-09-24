namespace GestionEmpleados.Models
{
    abstract class Persona
    {
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected byte Edad { get; set; }

        public Persona(string nombre, string apellido, byte edad)
        {
            Nombre = nombre;
            Apellido = apellido; 
            Edad = edad;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}");
        }
    }
}