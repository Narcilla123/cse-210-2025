using System;
using System.Collections;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
class ListAnalyzer
{
    static void Main(string[] args)
    {
        System.Collections.Generic.List<int> numbers = GetUserNumbers();

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered besides 0. Closing program");
            return;
        }
        Console.WriteLine();

        int sum = ComputeSum(numbers);
        Console.WriteLine($"The sum is: {sum}");

        ComputeAverage(sum, numbers.Count);

        FindMaximum(numbers);

    }
    static List<int> GetUserNumbers()
    {
        System.Collections.Generic.List<int> numbers = new System.Collections.Generic.List<int>();
        int input = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter Number: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input != 0)
                {
                    numbers.Add(input);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Enter a whole number please");
                input = -1;

            }

        } while (input != 0);
            
            return numbers;
        
    }

    static int ComputeSum(System.Collections.Generic.List<int> numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static void ComputeAverage(int sum, int count)
    {
        double average = (double)sum / count;
        Console.WriteLine($"The average is: {average}");
    }
    
    static void FindMaximum(System.Collections.Generic.List<int> numbers)
    {
        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}