namespace Nini_Beridze
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