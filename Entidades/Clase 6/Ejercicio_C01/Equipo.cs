namespace Entidades.Clase_6.Ejercicio_C01
{
    public class Equipo
    {
        short cantidadJugadores;
        List<Jugador> jugadores;
        string nombre;
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this() 
        {
            this.nombre = nombre;
            cantidadJugadores = cantidad;
        }
        public static bool operator +(Equipo e , Jugador j)
        {
            bool sePuedeAgregarJugador = true;
            if (e.jugadores.Count > 0 && e.jugadores.Count < e.cantidadJugadores)
            {
                sePuedeAgregarJugador = false;
                foreach (Jugador jugador in e.jugadores)
                {
                    sePuedeAgregarJugador |= jugador == j;
                    //sePuedeAgregarJugador = sePuedeAgregarJugador || jugador == j;
                }
            }
            if (!sePuedeAgregarJugador)
            {
                e.jugadores.Add(j);
            }
            return !sePuedeAgregarJugador;
        }
    }
}
