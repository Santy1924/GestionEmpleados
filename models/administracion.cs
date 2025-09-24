using System;
namespace GestionEmpleados.Models
{
	public static class Administracion
	{
		public static Empleado CrearEmpleado()
		{
			Console.Write("Nombre: ");
			string nombre = Console.ReadLine() ?? string.Empty;
			Console.Write("Apellido: ");
			string apellido = Console.ReadLine() ?? string.Empty;
			Console.Write("Edad: ");
			byte edad = byte.TryParse(Console.ReadLine(), out var e) ? e : (byte)0;
			Console.Write("Número de Identificación: ");
			string numeroId = Console.ReadLine() ?? string.Empty;
			Console.Write("Posición: ");
			string posicion = Console.ReadLine() ?? string.Empty;
			Console.Write("Salario: ");
			decimal salario = decimal.TryParse(Console.ReadLine(), out var s) ? s : 0;
			return new Empleado(nombre, apellido, edad, numeroId, posicion, salario);
		}

		public static Cliente CrearCliente()
		{
			Console.Write("Nombre: ");
			string nombre = Console.ReadLine() ?? string.Empty;
			Console.Write("Apellido: ");
			string apellido = Console.ReadLine() ?? string.Empty;
			Console.Write("Edad: ");
			byte edad = byte.TryParse(Console.ReadLine(), out var e) ? e : (byte)0;
			Console.Write("Email: ");
			string email = Console.ReadLine() ?? string.Empty;
			Console.Write("Teléfono: ");
			string telefono = Console.ReadLine() ?? string.Empty;
			return new Cliente(nombre, apellido, edad, email, telefono);
		}

		public static void MostrarTitulo(string titulo)
		{
			Console.Clear();
			Console.WriteLine($"==== {titulo.ToUpper()} ====");
			MostrarSeparador();
		}

		public static void MostrarPie(string pie)
		{
			MostrarSeparador();
			Console.WriteLine($"==== {pie} ====");
		}

		public static void MostrarSeparador()
		{
			Console.WriteLine(new string('-', 40));
		}
	}
}
