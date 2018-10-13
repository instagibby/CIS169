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
 Module 7 Foreach Loop
 Project Description: User is prompted for a number, if the user enters a
    that is between 1-100 (inclusive) and actually a number, the number is 
    set to the value of that index of the array. If not the user is informed 
    the error and asked again for another number.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M07_Davis_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int count = 4;
            double total = 0;
            double testScore = 0;
            double[] testScores = new double[4];


            for (int i = 0; i < testScores.Length; i++)
            {
                Console.WriteLine("Enter a test score!");   // Prompt for user input
                bool nextTestScore = false;

                //  Forces user to renter a value if it is enter incorrectly
                while (!nextTestScore)
                {
                    try
                    {
                        string input = Console.ReadLine();  // Accept user input
                        testScore = double.Parse(input);    // Parse input for int
                        //  Tests if int was between 1-100
                        if (testScore >= 1 && testScore <= 100)
                        {
                            testScores[i] = testScore;  //  Sets the value
                            nextTestScore = true;       //  Ends the while loop
                        }
                        else
                        {
                            Console.WriteLine("Try again, scores are from 1-100.");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Please enter a number from 1-100");
                    }
                }
            }

            foreach (double val in testScores)
            {
                total += val;
            }
            total = total / count;          // Get total average
            total = Math.Round(total, 2);   // round to nearest 2
            Console.WriteLine("Your average test score is: " + total);

            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
