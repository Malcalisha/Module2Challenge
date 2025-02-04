using System;

class Program
{
    static void Main()
    {
        // Step 1: Get user input for miles driven
        Console.Write("Enter the number of miles driven: ");
        string milesInput = Console.ReadLine();
        double milesDriven;

        // Step 2: Validate miles input
        if (!double.TryParse(milesInput, out milesDriven) || milesDriven <= 0)
        {
            Console.WriteLine("Invalid input! Miles driven must be a positive number.");
            return;
        }

        // Step 3: Get user input for gallons used
        Console.Write("Enter the amount of gasoline used (in gallons): ");
        string gallonsInput = Console.ReadLine();
        double gallonsUsed;

        // Step 4: Validate gallons input
        if (!double.TryParse(gallonsInput, out gallonsUsed) || gallonsUsed <= 0)
        {
            Console.WriteLine("Invalid input! Gallons used must be greater than zero.");
            return;
        }

        // Step 5: Calculate MPG
        double mpg = milesDriven / gallonsUsed;

        // Step 6: Display the result
        Console.WriteLine($"Your vehicle's fuel efficiency is {mpg:F2} miles per gallon (MPG).");
    }
}