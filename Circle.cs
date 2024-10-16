namespace Nini_Beridze
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                CalculateArea();
            }
        }

        private void CalculateArea()
        {
            area = Math.PI * radius * radius;
        }
    }
}