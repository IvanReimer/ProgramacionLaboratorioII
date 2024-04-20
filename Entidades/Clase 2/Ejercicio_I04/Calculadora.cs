namespace Entidades.Clase_2.Ejercicio_I04
{
    public static class Calculadora
    {

        public static int Calcular(int primerOperando, int segundoOperando, string operador)
        {
            switch (operador)
            {
                case "-":
                    return primerOperando - segundoOperando;
                case "*":
                    return primerOperando * segundoOperando;
                case "/":
                    if (Validar(segundoOperando))
                    {
                        return primerOperando / segundoOperando;
                    }
                    else
                    {
                        return 0;
                    }
                default:
                    return primerOperando + segundoOperando;
            }
        }
        private static bool Validar(int operando)
        {
            return operando != 0;
        }
    }
}
