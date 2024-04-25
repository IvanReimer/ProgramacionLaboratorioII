using System.Text;

namespace Entidades.Clase_5.Ejercicio_I02
{
    public class Estante
    {
        int ubicacionEstante;
        Producto[] productos;
        private Estante(int capacidad)
        {
            productos= new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }
        public Producto[] Productos
        {
            get { return productos; }
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new();
            sb.AppendLine($"Ubicación del estante: {e.ubicacionEstante}" );
            foreach (var item in e.productos)
            {
                if (item is not null)
                {
                    sb.AppendLine(Producto.MostrarProducto(item));
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e , Producto p)
        {
            foreach (var item in e.productos)
            {
                if (item is not null && item == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e , Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e , Producto p)
        {
            int aux;
            if (e != p && ValidadorDeEstantes.TieneEstantesLibres(e, out aux))
            {
                e.productos[aux] = p;
                return true;
            }
            return false;
        }
        public static bool operator -(Estante e , Producto p)
        {
            int aux;
            if (e!=p && ValidadorDeEstantes.TieneEstantesLibres(e,out aux))
            {
                e.productos[aux] = p;
                return true;
            }
            return false; 
        }
    }
}
