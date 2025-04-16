using System;

class Program
{
    static void Main(string[] args)
    {

        MathAssignment assignment2 = new MathAssignment("Victor Njoku", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetAssignmentDetails());

        WritingAssignment assignment3 =  new WritingAssignment("Deborah Njoku", "European History", "The colonization of Nigeria", "Joe Moriba");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetAssignmentDetails());

    }
}