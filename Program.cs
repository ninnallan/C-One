using Nini_Beridze;

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
