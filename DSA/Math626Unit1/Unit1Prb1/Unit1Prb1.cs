﻿/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Prb1.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Demonstrate selection sort on an array         */
/*                                                          */
/************************************************************/

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Unit1Prb1
{
    class Unit1Prb1
    {
        // Define input/output files
        const string DATA_FILE_NAME = "Data.txt";
        const string REPORT_FILE_NAME = "SortedData.txt";

        static StreamReader fileIn;
        static StreamWriter fileOut;

        static int numData; // number of data points

        // Arrays below store raw grades
        static double[] data;

        // Main entry point into the application
        static void Main()
        {
            IdentifyApplication();
            ParseDataFile();
            Sort();
            PrintResults();
        }
        static void IdentifyApplication()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("  Application: Unit1Prb1 - Selection sort");
            Console.WriteLine();
            Console.WriteLine("  ******************************************************************\n");
        }
        static void ParseDataFile()
        {
            string lineIn;
            string[] words;

            int i, j, k;


            fileIn = File.OpenText(DATA_FILE_NAME);

            fileIn.ReadLine();
            numData = int.Parse(fileIn.ReadLine());
            fileIn.ReadLine();

            data = new double[numData];

            for (i = 0; i < numData; i++)
            {
                data[i] = double.Parse(fileIn.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Data read from file " + DATA_FILE_NAME);

            fileIn.Close();
        }

        static void Sort()
        {

            int i, j, min;
            double aux;
            for (i = 0; i < numData; i++)
            {
                min = i;
                for (j = i + 1; j < numData; j++)
                {
                    if (data[min] > data[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    aux = data[min];
                    data[min] = data[i];
                    data[i] = aux;
                }
            }

        }

        static void PrintResults()
        {
            int i;

            fileOut = new StreamWriter(REPORT_FILE_NAME);

            fileOut.WriteLine("Number of data points:");
            fileOut.WriteLine(numData.ToString());
            fileOut.WriteLine("*************************");

            for (i = 0; i < numData; i++)
            {
                fileOut.WriteLine("{0}", data[i]);
            }

            fileOut.Close();

            Console.WriteLine();
            Console.WriteLine("Sorted data written to " + REPORT_FILE_NAME);
        }
    }
}