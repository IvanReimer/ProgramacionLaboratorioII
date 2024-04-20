using System.ComponentModel;
using System.Text;

namespace Entidades.Clase_3.Ejercicio_I04
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima=100;

        private ConsoleColor color;

        private short tinta;

        public Boligrafo(short tinta , ConsoleColor color)
        {
            this.color= color;
            if (tinta > 0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta= tinta;
            }
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return tinta;
        }
        private void SetTinta(short tinta)
        {
            short nuevoNivel = GetTinta();
            bool sePuedeModificar = (tinta + nuevoNivel) >= 0 && (nuevoNivel + tinta) <= cantidadTintaMaxima;
            if ( sePuedeModificar)
            {
                this.tinta += tinta;
            }
        }
        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }
        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - GetTinta()));
        } 
        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder sb = new();
            char unidadDeTinta = '*';
            short minimo = Math.Min(GetTinta(), gasto);
            if (gasto > 0)
            {
                for (int i = 0; i < minimo; i++)
                {
                    sb.Append(unidadDeTinta);
                }
                SetTinta((short)-gasto);
            }
            dibujo = sb.ToString();
            Console.ForegroundColor = this.GetColor();
            return dibujo.Length > 0;
        }
    }
}
