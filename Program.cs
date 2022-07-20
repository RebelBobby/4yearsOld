internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=> String interpolation.");
        int age = 4;
        string name = "Joe Matulewicz";

        string greeting = string.Format("Hello {0} you are {1} years old", name, age);

        Console.WriteLine(greeting);

        string greeting1 = $"Hellow {name} you are {age} years old.";
        Console.WriteLine(greeting1);
    }
}