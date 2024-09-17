/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Smp2.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Explore the Collatz or Hailstone conjecture    */
/*           using recursion.                               */
/*                                                          */
/************************************************************/

namespace Unit2Smp2
{
    class Unit2Smp2
    {
        static string reportFileName = "CollatzReport.txt";
        static StreamWriter fileOut;
        static ulong n;
        static int steps, maxSteps;
        static bool reachedOne = false;

        static void Main()
        {
            IdentifyApplication();
            GetStartingNumber();
            OpenReport();
            Collatz(n);
            CloseReport();
        }

        static void Collatz(ulong x)
        {
            Console.WriteLine(x.ToString());
            fileOut.WriteLine(x.ToString());

            if (x > 1 && steps < maxSteps)
            {
                steps++;
                switch (x % 2)
                {
                    case 0: Collatz(x / 2); break;
                    case 1: Collatz(3 * x + 1); break;
                }
            }
            else if (x == 1)
            {
                reachedOne = true;
            }
        }

        static void IdentifyApplication()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine("  Application: Unit2Smp2 - Collatz Conjecture");
            Console.WriteLine();
            Console.WriteLine("  ******************************************************************\n");
            Console.WriteLine();
        }

        static void GetStartingNumber()
        {
            Console.Write("Starting number: ");
            n = ulong.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Maximum steps before terminating: ");
            maxSteps = int.Parse(Console.ReadLine());
            Console.WriteLine();

            steps = 0;
        }
        static void OpenReport()
        {
            reportFileName = "CollatzReport" + n.ToString() + ".txt";
            fileOut = new StreamWriter(reportFileName);
        }
        static void CloseReport()
        {
            Console.WriteLine("********************************");
            fileOut.WriteLine("********************************");

            if (reachedOne)
            {
                Console.WriteLine("Collatz sequence starting with {0} reached 1 in {1} iterations", n, steps);
                fileOut.WriteLine("Collatz sequence starting with {0} reached 1 in {1} iterations", n, steps);
            }
            else
            {
                Console.WriteLine("Collatz sequence starting with {0} failed to reach 1 in {1} iterations", n, steps);
                fileOut.WriteLine("Collatz sequence starting with {0} failed to reach 1 in {1} iterations", n, steps);
            }

            fileOut.Close();
            Console.WriteLine("Report written to " + reportFileName);
        }
    }
}