namespace Entidades.Clase_2.Ejercicio_I02
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
        public static bool Validar(string rta)
        {
            return rta.ToLower() == "s";
        }
    }
}
