using System.Text;

namespace Entidades.Clase_5.Ejercicio_I02
{
    public class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string Marca
        {
            get { return this.marca; }
        }
        public float Precio
        {
            get
            {
                return this.precio;
            }
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1 , Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }
        public static bool operator != (Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator == (Producto p, string marca)
        {
            return p.marca == marca;
        }
        public static bool operator != (Producto p, string marca)
        {
            return !(p == marca);
        }


        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new();
            sb.AppendLine("------------------------------Producto----------------------------");
            sb.AppendLine("Marca: " + p.marca);
            sb.AppendLine("Precio: " + p.precio);
            sb.AppendLine("Código de barras: "+p.codigoDeBarra);
            sb.AppendLine("------------------------------------------------------------------");
            return sb.ToString();
        }
    }
}
