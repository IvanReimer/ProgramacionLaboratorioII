namespace Entidades.Clase_5.Ejercicio_I02
{
    public static class ValidadorDeEstantes
    {
        public static bool TieneEstantesLibres(Estante e, out int estanteLibre)
        {
            estanteLibre = -1;
            for(int i =0; i < e.Productos.Length; i++)
            {
                if (e.Productos[i] is null)
                {
                    estanteLibre = i;
                    return true;
                }
            }
            return false;
        }

    }
}
