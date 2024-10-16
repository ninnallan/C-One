using Nini_Beridze;
/*Declare and initialize an integer variable named 
"myAge" with your age.

Declare and initialize a double variable named "bankBalance" 
with a random value (e.g., 1500.75).

Implement a conditional statement (if-else) that checks whether
 your bank balance is greater than or equal to 1000. If it is, 
 print "I have a healthy bank balancel" Otherwise, print "I need to save more."
*/
public class Balance
{
    static void Main()
    {
        int myAge = 20;

        double bankBalance = 1500.75;

        if (bankBalance >= 1000)
        {
            Console.WriteLine("I have a healthy bank balance!");
        }
        else
        {
            Console.WriteLine("I need to save more.");
        }
    }
}
/*Create instances of "Rectangle" and "Circle," set their dimensions, and display their areas.
*/
 public class Calculate
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 10;
        rectangle.Width = 15;

        Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

        Circle circle = new Circle();
        circle.Radius = 30;

        Console.WriteLine($"Area of the circle: {circle.Area}");
    }
}
