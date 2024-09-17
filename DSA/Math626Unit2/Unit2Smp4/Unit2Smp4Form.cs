/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Smp4.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Produce all possible binary strings of         */
/*           given length.                                  */
/*                                                          */
/************************************************************/

namespace Unit2Smp4
{
    public partial class Unit2Smp4Form : Form
    {

        int[] binaryArray;
        int stringLength = 0;
        int numOfCalls = 0;
        int numOfStrings = 0;
        public Unit2Smp4Form()
        {
            InitializeComponent();
        }
        private void GenStrings(int position)
        {
            numOfCalls++;

            if (position == stringLength)
            {
                PrintCharArray();
                numOfStrings++;
            }
            else
            {
                binaryArray[position] = 0;
                GenStrings(position + 1);

                binaryArray[position] = 1;
                GenStrings(position + 1);
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            numOfCalls = 0;
            numOfStrings = 0;

            stringLength = int.Parse(lengthTextBox.Text);
            binaryArray = new int[stringLength];

            outputTextbox.Clear();

            GenStrings(0);

            recursiveCallsTextBox.Text = numOfCalls.ToString();
            numStringsTextBox.Text = numOfStrings.ToString();
        }

        private void PrintCharArray()
        {
            string stringToPrint = "";
            int i;

            for (i = 0; i < stringLength; i++)
            {
                stringToPrint += binaryArray[i].ToString();

            }
            outputTextbox.Text += stringToPrint;
            outputTextbox.Text += System.Environment.NewLine;
        }
    }
}