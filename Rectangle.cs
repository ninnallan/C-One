namespace Nini_Beridze
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                CalculateArea();
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                CalculateArea();
            }
        }

        private void CalculateArea()
        {
            area = length * width;
        }
    }
}