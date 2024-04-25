namespace Entidades.Clase_3.Ejercicio_I01
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
        public Cuenta(string titular ,decimal cantidad)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }

        public string Mostrar()
        {
            return $"Titular: {this.cantidad}. Cantidad: {this.cantidad}.";
        }
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad =+ monto;
            }
        }
        public void Retirar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}