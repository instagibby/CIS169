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
 Module 7 Array Basics
 Project Description: Console Program that prompts the user to test scores
    for each student to save in an array, averages the test scores, and then
    writes the results for the user to see.


 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace M07_Davis_ArrayBasics
{
    class Program
    {
        //  Method to set the values of arrays for the student
        public static void SetArrayValues(ref int[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter a value for test number " + (i+1) + ".");
                student[i] = int.Parse(Console.ReadLine());
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
            int[] spencerTestScores = new int[3];
            int[] claireTestScores = new int[5];
            int[] gibbyTestScores = new int[4];



            try
            {
                //  My test scores
                Console.WriteLine("Please input Spencer's scores!");
                SetArrayValues(ref spencerTestScores);

                //  Claire's test scores
                Console.WriteLine("Please input Claire's scores!");
                SetArrayValues(ref claireTestScores);

                //  Gibby's test scores
                Console.WriteLine("Please input Gibby's scores!");
                SetArrayValues(ref gibbyTestScores);

                //  Get easy printable strings with scores.
                spencerScoreString = string.Join(", ", spencerTestScores);
                claireScoreString = string.Join(", ", claireTestScores);
                gibbyScoreString = string.Join(", ", gibbyTestScores);

                //  Made a method to average a persons test scores and run it here
                //  to average the stores currently in the array per student
                AvgTestScore(spencerTestScores, ref spencerTestAverage);
                AvgTestScore(claireTestScores, ref claireTestAverage);
                AvgTestScore(gibbyTestScores, ref gibbyTestAverage);

                //  Write it all to the user
                Console.WriteLine("Spencer " + spencerScoreString + ". Avg: " + spencerTestAverage);
                Console.WriteLine("Claire " + claireScoreString + ". Avg: " + claireTestAverage);
                Console.WriteLine("Gibby " + gibbyScoreString + ". Avg: " + gibbyTestAverage);
                

                //  To Exit
                Console.WriteLine("Press any key to exit!");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
