using Entidades;
namespace Clases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int output;

            Console.WriteLine("Ingrese un numero");

            string? buffer = Console.ReadLine();
            if (buffer is not null && int.TryParse(buffer, out output))
            {
                Console.WriteLine(GeneradorTablas.GenerarTabla(output));
            }
        }
    }
}