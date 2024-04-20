namespace Entidades.Clase_2.Ejercicio_A01
{
    public static class CalculadoraFactorial
    {
        public static double Calcular(int numero)
        {
            double factorial = 1;
            while(numero > 0)
            {
                factorial *= numero;
                numero--;
            }
            return factorial;
        }

    }
}
