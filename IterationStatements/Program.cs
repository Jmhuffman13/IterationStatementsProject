using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

           

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            var myNumber = 0;



            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                myNumber++;
                // Then add your variable to "numbers"
                numbers.Add(myNumber);
            } while (true);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            while (myNumber < 200)
            {
                // Increment your variable by 1
                myNumber++;
                // Then add your variable to "numbers"
                numbers.Add(myNumber);
            }

            // Create a foreach loop
            Console.WriteLine("Increase");
            foreach (var item in numbers)
            {
                // Write your variable to the console

                Console.WriteLine(item);
                // or Console.Writeline($"{item}";
               
            }
                Console.WriteLine("Decrease:");

            for(int i = 199; i<= numbers.Count && i>=0; i--)
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                Console.WriteLine("{numbers{i}}");
                // Write to the console "numbers" at index i
            }
        }
    }
}
