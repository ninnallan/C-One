namespace Nini_Beridze
/* Create a class named 'Person" with the following members:
A public property for "Name" with get and set accessors.

A constructor that takes two parameters to initialize the age and name.

Implement a public method called "PrintDetails" that prints the person's
 name and age to the console. Create an instance of the "Person" class, 
 set its name and age, and call the "PrintDetails" method to display the 
 information.
*/
{
    public class Person
    {
        private int age;
        public string Name { get; set; }

        public Person(int age, string name)
        {
            this.age = age;
            this.Name = name;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person(20, "Nini");

            person.PrintDetails();
        }
    }
}