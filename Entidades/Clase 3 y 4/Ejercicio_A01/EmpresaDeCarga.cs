using System.Text;

namespace Entidades.Clase_3.Ejercicio_A01
{
    public class EmpresaDeCarga
    {
        private List<Conductor> conductor;

        public EmpresaDeCarga(List<Conductor> conductores)
        {
            conductor = conductores;
        }
        public string ConductorDelDia(EDiasSemana dia)
        {
            string conductorDelDia = "Son todos unos vagos, nadie hizo nada.";
            float maxKilometraje = -1;
            bool flag = true;
            float aux = -1;
            foreach (var item in conductor)
            {
                if (flag && float.TryParse(item.KilometrosDia(dia), out maxKilometraje))
                {
                    flag = false;
                    conductorDelDia = item.ToString();
                }
                if (!flag && float.TryParse(item.KilometrosDia(dia), out aux) && aux > maxKilometraje )
                {
                    maxKilometraje = aux;
                    conductorDelDia = item.ToString();
                }
            }
            return conductorDelDia;
        }
        public string ConductorDeLaSemana()
        {
            string conductorDeLaSemana= "Son todos unos vagos, nadie hizo nada.";
            bool flag = true;
            float aux = -1;
            foreach (var item in conductor)
            {
                if (flag && item.KilometrosTotales() > 0)
                {
                    flag = false;
                    conductorDeLaSemana = item.ToString();
                    aux = item.KilometrosTotales();
                }
                if (!flag && item.KilometrosTotales() > aux)
                {
                    conductorDeLaSemana = item.ToString();
                    aux = item.KilometrosTotales();
                }
            }
            return conductorDeLaSemana;
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            foreach(var item in conductor)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
