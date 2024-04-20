namespace Entidades.Clase_2.Ejercicio_I08
{
    public static class CalculadoraDiasVividos
    {
        public static double Calcular(DateTime fechaNacimiento)
        {
            TimeSpan resultado = DateTime.Today - fechaNacimiento;
            return resultado.Days;
        }
    }
}
