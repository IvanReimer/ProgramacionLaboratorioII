using System.Text;

namespace Entidades.Clase_6.Ejercicio_C01
{
    public class Jugador : Persona
    {
        int partidosJugados;
        int totalGoles;

        public Jugador(int dni , string nombre) : base(dni,nombre) { }

        public Jugador(int dni, string nombre,int partidosJugados, int totalGoles):this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Goles convertidos: {totalGoles}");
            return sb.ToString();
        }
        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2) { return !(j1 == j2); }
    }
}
