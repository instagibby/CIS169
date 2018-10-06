using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** =========================================================

 Spencer Davis
 Windows 7
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Module 5 Average Test Scores For Loop
 Project Description: Console program to take a user input while the count is
    less than three. This allows the console to take 3 values and then averages
    the values to output a final test score average.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M05_Davis_AverageTestScoresWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int counter = 0;           
            double total = 0;
            double testScore = 0;

            // While loop
            //while (counter < 3)

            // New for loop
            //for (counter = 0; counter < 4; counter++)
            do
            {
                Console.WriteLine("Enter a test score!");   // Prompt for user input
                string input = Console.ReadLine();          // Accept user input
                testScore = double.Parse(input);            // Parse input for double

                counter++;
                total = total + testScore;
            } while (counter < 3);

            total = total / counter;        // Get total average
            total = Math.Round(total, 2);   // round to nearest 2
            Console.WriteLine("Your average test score is: " + total);

            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
