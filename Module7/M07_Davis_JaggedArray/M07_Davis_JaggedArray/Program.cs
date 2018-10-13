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
 Module 7 Jagged Array
 Project Description: Console Program that prompts the user to test scores
    for each student to save in a jagged array, averages the test scores, and then
    writes the results for the user to see.

 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/



namespace M07_Davis_JaggedArray
{
    class Program
    {
        //  Method to set the values of arrays for the student
        public static void SetArrayValues(ref int[] student, int y)
        {
            for (int x = 0; x < student.Length; x++)
            {
                Console.WriteLine("Enter a value for test number " + (x + 1) + ".");
                student[x] = int.Parse(Console.ReadLine());
            }

        }
        //  Method to average the test scores for the student
        public static void AvgTestScore(int[] studentScoresArray, ref double studentTestAverage)
        {
            for (int i = 0; i < studentScoresArray.Length; i++)
            {
                studentTestAverage += studentScoresArray[i];
            }
            studentTestAverage = studentTestAverage / studentScoresArray.Length;
            studentTestAverage = Math.Round(studentTestAverage, 2);
        }

        static void Main(string[] args)
        {
            //  Declare Variables
            double spencerTestAverage = 0;
            double claireTestAverage = 0;
            double gibbyTestAverage = 0;
            string spencerScoreString = "";
            string claireScoreString = "";
            string gibbyScoreString = "";
            string printLineSpacing = "------------------------------";

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[4];



            try
            {
                //  My test scores
                Console.WriteLine("Please input Spencer's scores!");
                SetArrayValues(ref jaggedArray[0], 0);

                //  Claire's test scores
                Console.WriteLine("Please input Claire's scores!");
                SetArrayValues(ref jaggedArray[1], 1);

                //  Gibby's test scores
                Console.WriteLine("Please input Gibby's scores!");
                SetArrayValues(ref jaggedArray[2], 2);

                //  Get easy printable strings with scores.
                spencerScoreString = string.Join(", ", jaggedArray[0]);
                claireScoreString = string.Join(", ", jaggedArray[1]);
                gibbyScoreString = string.Join(", ", jaggedArray[2]);

                //  Made a method to average a persons test scores and run it here
                //  to average the stores currently in the array per student
                AvgTestScore(jaggedArray[0], ref spencerTestAverage);
                AvgTestScore(jaggedArray[1], ref claireTestAverage);
                AvgTestScore(jaggedArray[2], ref gibbyTestAverage);

                //  Write it all to the user
                Console.WriteLine(printLineSpacing);
                Console.WriteLine("Spencer " + spencerScoreString + ". Avg: " + spencerTestAverage);
                Console.WriteLine("Claire " + claireScoreString + ". Avg: " + claireTestAverage);
                Console.WriteLine("Gibby " + gibbyScoreString + ". Avg: " + gibbyTestAverage);
                Console.WriteLine(printLineSpacing);

                //  To Exit
                Console.WriteLine("Enter any key to exit!");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
   