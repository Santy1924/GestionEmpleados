namespace GestionEmpleados.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte Edad { get; set; }

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