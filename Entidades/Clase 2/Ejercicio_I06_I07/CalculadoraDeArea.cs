namespace Entidades.Clase_2.Ejercicio_I05_I06
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double _base, double altura) 
        { 
            return (_base * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        { 
            return radio * Math.PI;
        }
        public static double CalcularHipotenusa(double _base , double altura)
        {
            return Math.Sqrt(Math.Pow(_base,2) + Math.Pow(altura,2));
        }
    }
}
