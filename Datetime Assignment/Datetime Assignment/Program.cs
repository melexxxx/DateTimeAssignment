// Import the necessary namespace for working with dates and times
using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            DateTime now = DateTime.Now;  // Get the current date and time
            Console.WriteLine("Current date and time: " + now);

            // Ask the user for a number (hours to add)
            Console.WriteLine("Please enter a number of hours:");
            int hoursToAdd = Convert.ToInt32(Console.ReadLine());  // Convert input to an integer

            // Calculate the future time by adding the entered number of hours
            DateTime futureTime = now.AddHours(hoursToAdd);  // Add the user-specified hours

            // Print the exact time it will be after the given hours
            Console.WriteLine("In {0} hours, it will be: {1}", hoursToAdd, futureTime);

            // Keep the console window open until the user presses a key
            Console.ReadKey();
        }
    }
}
