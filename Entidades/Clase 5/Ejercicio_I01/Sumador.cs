namespace Entidades.Clase_5.Ejercicio_I01
{
    public class Sumador
    {
        int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador():this(1)
        {

        }

        public long Sumar(long a,long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a , string b)
        {
            cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }
        public static Boolean operator |(Sumador s1, Sumador s2)
        {
            return (int)s1  == (int)s2;
        }
    }
}
