using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letter;
        int lastDigit = grade % 10;

        if (grade < 60)
        {
            letter = "F"; 
        }
        else if (grade >= 60 && grade < 70 && lastDigit > 3 && lastDigit < 7)
        {
            letter = "D";
        }
        else if (grade >= 60 && grade < 70 && lastDigit <= 3)
        {
            letter = "D-"; 
        }
        else if (grade >= 60 && grade < 70 && lastDigit >= 7)
        {
            letter = "D+";
        }
        else if (grade >= 70 && grade < 80 && lastDigit > 3 && lastDigit < 7)
        {
            letter = "C";
        }
        else if (grade >= 70 && grade < 80 && lastDigit < 3)
        {
            letter = "C-";
        }
        else if (grade >= 70 && grade < 80 && lastDigit >= 7)
        {
            letter = "C+";
        }
        else if (grade >= 80 && grade < 90 && lastDigit > 3 && lastDigit < 7)
        {
            letter = "B";
        }
        else if (grade >= 80 && grade < 90 && lastDigit < 3)
        {
            letter = "B-";
        }
        else if (grade >= 80 && grade < 90 && lastDigit >= 7)
        {
            letter = "B+";
        }
        else if (grade > 90 && lastDigit < 3)
        {
            letter = "A-";
        }
        else
        {
            letter = "A";
        }

        Console.WriteLine($"You got {letter} in the course.");

        if (grade < 70)
        {
            Console.WriteLine("You have failed, you can do better next time.");
        }
        else
        {
            Console.WriteLine("Congratulations, you have passed this course!");
        }
    }
}