namespace Nini_Beridze
/*The "Circle" class should inherit from "Shape" and 
have a private field for "radius." Implement properties 
for "Radius" with get and set accessors in the "Circle" class.
Calculate and set the area of a circle when an object is created.
*/
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