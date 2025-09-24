using System;
using System.Collections.Generic;
using System.Linq;


namespace GestionEmpleados.Models
{
    public class Empleado : Persona
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string NumeroDeIdentificacion { get; set; }
        public string Posicion { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string apellido, byte edad, string numeroDeIdentificacion, string posicion, decimal salario)
            : base(nombre, apellido, edad)
        {
            NumeroDeIdentificacion = numeroDeIdentificacion;
            Posicion = posicion;
            Salario = salario;
        }



        private decimal CalcularBonificacion()
        {
            return Salario * 0.10m;
            
        }

        public override void MostrarInformacion()
        {
            decimal salarioConBonificacion = Salario + CalcularBonificacion();
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}, Posición: {Posicion}, Salario con bonificación: {salarioConBonificacion:C}");
        }



    }
}
