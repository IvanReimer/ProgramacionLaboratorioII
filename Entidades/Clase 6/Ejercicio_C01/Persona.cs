using System.Text;

namespace Entidades.Clase_6.Ejercicio_C01
{
    public class Persona
    {
        long dni;
        string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre): this(nombre)
        {
            this.dni = dni;
        }
        public long Dni
        {
            get
            {
                return dni;
            }
            set
            {
                if (value >= 0)
                {
                    dni = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value is not null && value != string.Empty )
                {
                    nombre = value;
                }
            }
        }
        public string MostrarDatos()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");
            return sb.ToString();
        }


    }
}
