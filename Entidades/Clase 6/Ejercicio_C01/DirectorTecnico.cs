using System.Text;

namespace Entidades.Clase_6.Ejercicio_C01
{
    public class DirectorTecnico: Persona
    {
        DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) : base(nombre){}

        public DirectorTecnico(string nombre, DateTime fechaNacimiento): base(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha nacimiento: {fechaNacimiento}");
            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1 , DirectorTecnico dt2)
        {
            return dt1.fechaNacimiento == dt2.fechaNacimiento && dt1.Nombre == dt2.Nombre;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }


    }
}
