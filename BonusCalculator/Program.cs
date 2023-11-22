using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BonusCalculator
{
    // Method to get a valid input from the user
    static double GetInput(string prompt)
    {
        double input;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out input) || input < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
        return input;
    }

    // Method to calculate the bonus based on the salary and years of service
    static double CalculateBonus(double salary, double years)
    {
        double bonus = 0;
        if (years >= 20)
        {
            bonus = salary * 0.1; // 10% bonus for 20 or more years of service
        }
        else if (years >= 10)
        {
            bonus = salary * 0.05; // 5% bonus for 10 or more years of service
        }
        else if (years >= 5)
        {
            bonus = salary * 0.025; // 2.5% bonus for 5 or more years of service
        }
        return bonus;
    }

    // Main method to run the program
    static void Main(string[] args)
    {
        // Declare variables
        string name;
        double salary, years, bonus, newSalary;
        char choice;

        // Loop until the user wants to quit
        do
        {
            // Get the employee name
            Console.Write("Please enter the employee name: ");
            name = Console.ReadLine();

            // Get the salary and years of service
            salary = GetInput("Please enter the base salary: ");
            years = GetInput("Please enter the total number of years of service: ");

            // Calculate the bonus and new salary
            bonus = CalculateBonus(salary, years);
            newSalary = salary + bonus;

            // Display the results
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Bonus: {0:C}", bonus);
            Console.WriteLine("New salary: {0:C}", newSalary);

            // Ask the user if they want to continue
            Console.Write("Do you want to calculate another bonus? (Y/N): ");
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (choice == 'Y');

        // End the program
        Console.WriteLine("Thank you for using the bonus calculator.");
    }
}