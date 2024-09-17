/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Smp1.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Implement the calculation of factorial using   */
/*           recursion as well as an iterative approach.    */
/*                                                          */
/************************************************************/

namespace Unit2Smp1
{
    using System.Diagnostics;
    public partial class Unit2Smp1Form : Form
    {
        ulong x = 0;

        public Unit2Smp1Form()
        {
            InitializeComponent();
        }


        private void calcButton_Click_1(object sender, EventArgs e)
        {
            Stopwatch timerI = new Stopwatch();
            Stopwatch timerR = new Stopwatch();

            x = ulong.Parse(nTextBox.Text);

            timerI.Start();
            iterativeTextBox.Text = FactorialI(x).ToString();
            timerI.Stop();
            iterativeTimeTextBox.Text = timerI.Elapsed.ToString();
   
            timerR.Start();
            recursiveTextBox.Text = FactorialR(x).ToString();
            timerR.Stop();
            recursiveTimeTextBox.Text = timerR.Elapsed.ToString();
        }


        private ulong FactorialR(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FactorialR(n - 1);
            }
        }
        private ulong FactorialI(ulong n)
        {
            ulong i, m = 1;

            for (i = 1; i <= n; i++)
            {
                m *= i;
            }

            return m;
        }
    }
}