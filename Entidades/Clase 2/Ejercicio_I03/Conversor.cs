namespace Entidades.Clase_2.Ejercicio_I03
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            string reversedResult = String.Empty;

            while(numeroEntero >= 1)
            {
                reversedResult += (numeroEntero % 2).ToString();
                numeroEntero /= 2;
            }
            string result = string.Empty;
            for (int i = reversedResult.Length; i > 0; i--)
            {
                result += reversedResult[i-1];
            }
            return result;
        }
    }
}
