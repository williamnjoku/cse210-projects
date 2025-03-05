using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int maxNumber = 0;
        int smallestNumber = 999999;

        Console.WriteLine("Enter a series of numbers, positive or negative(type 0 to finish):");

        while (true) 
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0) 
                break;

            numbers.Add(number);
            sum += number;

            if (number > maxNumber)
                maxNumber = number;

            if (number < smallestNumber && number > 0)
                smallestNumber = number;
        }

        if (numbers.Count > 0) 
        {
            numbers.Sort();
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average:F2}");
            Console.WriteLine($"The maximum number is: {maxNumber}");
            Console.WriteLine($"The smallest positive number is: {smallestNumber}");

            Console.WriteLine("The sorted list is: ");

            foreach (int number in numbers)
        {
            
            Console.WriteLine(number);

        }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        
    }
}
