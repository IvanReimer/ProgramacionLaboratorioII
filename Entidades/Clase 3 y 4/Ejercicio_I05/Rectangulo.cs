namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3) 
        {
            this.vertice1 = vertice1;
            this.vertice3= vertice3;
            vertice2 = new(vertice3.getX(), vertice1.getY());
            vertice4 = new(vertice1.getX(), vertice3.getY());
            perimetro = Math.Abs(vertice1.getX() - vertice2.getX())*2 + Math.Abs(vertice1.getY() - vertice4.getY())*2;
            area = Math.Abs(vertice1.getX() - vertice2.getX()) * Math.Abs(vertice1.getY() - vertice4.getY());
        }
        public float Perimetro()
        {
            return perimetro;
        }
        public float Area()
        {
            return area;
        }
    }
}
