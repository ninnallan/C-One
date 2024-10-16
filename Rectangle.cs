namespace Nini_Beridze
/*The "Rectangle" class should inherit from "Shape" and 
have private fields for "length" and "width." Implement 
properties for "Length" and "Width" with get and set accessors 
in the "Rectangle" class.
Calculate and set the area of a rectangle when an object is created. 
*/
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