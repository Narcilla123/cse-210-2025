using System;

class Program
{

    static void TestValues(int x, float y, double z)
    {
        Console.WriteLine($"The values are: {x}, {y}, {z}");

    }
    static int AddValues(int n1, int n2, int n3)
    {
        int total = n1 + n2 + n3;
        return total;
    }

    static void OneLineFunction()
    {
        Console.WriteLine("AHAHHAHAHHH");
    }
    static void Main(string[] args)
    {
        TestValues(10, (float)123.234, 23423.2342342340);
        int total = AddValues(10, 20, 30);
        Console.WriteLine($"The total is: {total}");
        /*Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your First Name");
        firstName = Console.ReadLine();
        Console.Write("Please enter your Last Name");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");*/


    }

}