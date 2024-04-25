using System.Text;
namespace Entidades.Clase_3.Ejercicio_A01
{
    public class Conductor
    {
        string nombre;
        string apellido;
        float[] kilometrosRecorridos;
        private Conductor()
        {
            kilometrosRecorridos = new float[7];
        }
        public Conductor(string nombre, string apellido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            for (int i = 0; i < kilometrosRecorridos.Length; i++)
            {
                // PREGUNTAR POR QUÉ NO ME DEJA USAR UN FOREACH!!!!!!!
                kilometrosRecorridos[i] = -1;
            }
        } 
        public void SetKilometros(EDiasSemana dia , float kilometros)
        {
            if (kilometros >= 0)
            {
                kilometrosRecorridos[(int)dia] = kilometros;
            }
        }
        private float GetKilometros(ushort dia)
        {
            return kilometrosRecorridos[dia];
        }
        public float KilometrosTotales()
        {
            float sumatoria = 0;
            foreach (var item in kilometrosRecorridos)
            {
                if (item > 0)
                {
                    sumatoria += item;
                }
            }
            return sumatoria;
        }
        public string KilometrosDia(EDiasSemana dia)
        {
            StringBuilder km = new();
            if (GetKilometros((ushort)dia) > 0)
            {
                km.AppendLine(GetKilometros((ushort)dia).ToString());
            }
            else if(GetKilometros((ushort)dia) == 0)
            {
                km.AppendLine("El conductor tiene franco.");
            }
            else
            {
                km.AppendLine("El conductor no hizo viajes aún.");
            }
            return km.ToString();
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("\r_____________________________________________________________");
            sb.AppendLine("DATOS DEL CONDUCTOR");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            float resultado = GetKilometros(2);
            sb.AppendLine($"El día miércoles, el conductor {(resultado > 0 ? $"realizó {resultado} kilómetros" : (resultado == 0 ? "tuvo franco" : "no trabajó aún"))}.");
            resultado = GetKilometros(4);
            sb.AppendLine($"El día viernes, el conductor {(resultado > 0 ? $"realizó {resultado} kilómetros" : (resultado == 0 ? "tuvo franco" : "no trabajó aún"))}.");
            sb.AppendLine($"Kilometros recorridos en la semana: {KilometrosTotales()}");
            sb.AppendLine("\r_____________________________________________________________");
            return sb.ToString();
        }
    }
}
