using System.Text;
namespace Entidades.Clase_2.Ejercicio_I05
{
    public static class GeneradorTablas
    {
        public static string GenerarTabla(int numero)
        {
            StringBuilder tabla = new StringBuilder();
            tabla.AppendLine($"Tabla de multiplicar del número: {numero}");
            for (int i = 1; i <= 10; i++)
            {
                tabla.AppendLine($"{numero} x {i} = {numero*i}");
            }
            return tabla.ToString();
        }
    }
}