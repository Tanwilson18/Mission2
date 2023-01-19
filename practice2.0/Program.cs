using System;

// Tanner Wilson Mission 2 Assignment 
class program
{
    static void Main(string[] args)
    {
        // prompt user to enter number of dice rolls
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.Write("Enter the number of times to roll the dice: ");

        int numRolls = int.Parse(Console.ReadLine());

        // Create an array to store the number of times each total is rolled
        int[] totals = new int[11];


        //print results 
        Console.Write("\n");
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each * represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls);
        Console.Write("\n");



        // loop to roll dice x amount of times at random
        Random rand = new Random();
        for (int i = 0; i < numRolls; i++)
        {
            int roll1 = rand.Next(1, 7);
            int roll2 = rand.Next(1, 7);
            int total = roll1 + roll2;
            totals[total - 2]++;
        }


        // for loop to Print the histogram
        for (int i = 0; i < 11; i++)
        {
            double percentage = (double)totals[i] / numRolls * 100;
            Console.WriteLine($"{i + 2}: {new string('*', (int)percentage)}");

        }
        Console.Write("\n");
        Console.Write("Thank you for using the dice throwing simulator. Goodbye!");

    }
}