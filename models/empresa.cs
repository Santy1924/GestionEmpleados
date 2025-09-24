using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionEmpleados.Models
{
    public class Empresa
    {
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();
        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
        }

        public void EliminarEmpleado(string nombre, string apellido)
        {
            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido))
            {
                ListaEmpleados.RemoveAll(e => e.Nombre == nombre && e.Apellido == apellido);
            }
        }

        public void MostrarTodosLosEmpleados()
        {
            foreach (var empleado in ListaEmpleados)
            {
                empleado.MostrarInformacion();
            }
        }

        public void ActualizarEmpleado(string numeroIdentificacion, Empleado nuevoEmpleado)
        {
            if (string.IsNullOrWhiteSpace(numeroIdentificacion) || nuevoEmpleado == null)
                return;
            var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroIdentificacion);
            if (empleado != null)
            {
                empleado.Nombre = nuevoEmpleado.Nombre ?? empleado.Nombre;
                empleado.Apellido = nuevoEmpleado.Apellido ?? empleado.Apellido;
                empleado.Edad = nuevoEmpleado.Edad;
                empleado.Posicion = nuevoEmpleado.Posicion ?? empleado.Posicion;
                empleado.Salario = nuevoEmpleado.Salario;
            }
        }

        public Empleado? BuscarEmpleado(string numeroIdentificacion)
        {
            if (string.IsNullOrWhiteSpace(numeroIdentificacion))
                return null;
            return ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroIdentificacion);
        }

        public void MostrarEmpleadosPorCargo(string cargo)
        {
            if (string.IsNullOrWhiteSpace(cargo))
                return;
            var empleadosFiltrados = ListaEmpleados
                .Where(e => e.Posicion != null && e.Posicion.Equals(cargo, StringComparison.OrdinalIgnoreCase));
            foreach (var empleado in empleadosFiltrados)
            {
                empleado.MostrarInformacion();
            }
        }

        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public void EliminarCliente(string nombre, string apellido)
        {
            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido))
            {
                ListaClientes.RemoveAll(c => c.Nombre == nombre && c.Apellido == apellido);
            }
        }

        public void MostrarTodosLosClientes()
        {
            foreach (var cliente in ListaClientes)
            {
                cliente.MostrarInformacion();
            }
        }
    }
}