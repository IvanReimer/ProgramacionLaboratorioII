using Entidades.Clase_2.Ejercicio_A01;
using Entidades.Clase_2.Ejercicio_I08;
using Entidades.Clase_3.Ejercicio_I04;
using Entidades.Ejemplos;
namespace Clases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int output;

            //Console.WriteLine("Ingrese un numero");

            //string? buffer = Console.ReadLine();
            //if (buffer is not null && int.TryParse(buffer, out output))
            //{
            //    Console.WriteLine(GeneradorTablas.GenerarTabla(output));
            //}

            //DateTime date = new DateTime(2000, 01, 18);

            //Console.WriteLine(CalculadoraDiasVividos.Calcular(date));

            //Console.WriteLine(  Conversor.ConvertirDecimalABinario(10) );

            Boligrafo b = new(10, ConsoleColor.Red);
            string dibujito=String.Empty;
            b.Pintar(2,out dibujito);
            Console.WriteLine(dibujito);
            Console.WriteLine(b.GetTinta());
            b.Recargar();
            Console.WriteLine(b.GetTinta());
        }
    }
}