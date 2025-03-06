using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(squaredNumber, userName);



    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }   
     static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }  
    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }  
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    static void DisplayResult(int squaredNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }

}