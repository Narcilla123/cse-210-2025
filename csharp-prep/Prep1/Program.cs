class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your First Name");
        firstName = Console.ReadLine();
        Console.Write("Please enter your Last Name");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");
    }
}