using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Clase_3.Ejercicio_I02
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public int GetDni()
        {
            return this.dni;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaDeNacimiento = fechaNacimiento;
        }
        private int CalcularEdad()
        {
            return (this.fechaDeNacimiento - DateTime.Now).Days;
        }
        public string EsMayorDeEdad()
        {
            return CalcularEdad() >= 18 ? "Es mayor de edad" : "Es menor";
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Edad: {this.CalcularEdad()}");
            return sb.ToString();
        }
    }
}
