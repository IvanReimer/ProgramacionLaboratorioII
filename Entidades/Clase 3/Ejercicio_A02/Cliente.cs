namespace Entidades.Clase_3.Ejercicio_A02
{
    public class Cliente
    {
        string domicilio;
        string nombre;
        string apellido;
        string telefono;
        Mascota[] mascotas;

        public Cliente(int cantMascotas , string telefono, string apellido , string nombre, string domicilio)
        {
            this.mascotas = new Mascota[cantMascotas];
            this.telefono = telefono;
            this.apellido = apellido;
            this.domicilio= domicilio;
            this.nombre = nombre;
        }

        public Mascota[] Mascotas
        {
            get
            {
                return mascotas;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }

        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Domicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }
    }
}
