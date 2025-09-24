
namespace GestionEmpleados.Models
{
    public class Cliente : Persona
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string apellido, byte edad, string email, string telefono)
            : base(nombre, apellido, edad)
        {
            Email = email;
            Telefono = telefono;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Email: {Email}, Teléfono: {Telefono}");
        }
    }
}
