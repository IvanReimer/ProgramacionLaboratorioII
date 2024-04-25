using System.Text;

namespace Entidades.Clase_3.Ejercicio_I03
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        static Estudiante()
        {
            random = new Random();
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        private float CalcularPromedio()
        {
            return this.notaPrimerParcial / this.notaSegundoParcial;
        }
        public double CalcularNotaFinal()
        {
            double notaFinal;
            if (CalcularPromedio() >= 4 )
            {
                notaFinal = random.Next(6,11);
            }
            else
            {
                notaFinal = -1;
            }
            return notaFinal;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            if (this.CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota final: {this.CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }
}
