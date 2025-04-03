using System;
// I created another activity, Visualization activity.
class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60);
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 45, 0);
                listing.Run();
            }
             else if (choice == "4")
            {
                VisualizationActivity visualization = new VisualizationActivity("Visualization", "This activity helps you relax by guiding you through a visualization exercise.", 60);
                visualization.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                Thread.Sleep(2000);
            }
        }
    }
}