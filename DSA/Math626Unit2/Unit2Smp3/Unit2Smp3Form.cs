/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Smp3.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Produce all possible strings of length L,      */
/*           using the first N letters of the alphabet.     */
/*                                                          */
/************************************************************/

namespace Unit2Smp3
{
    public partial class Unit2Smp3Form : Form
    {
        char[] charArray;
        int stringLength = 0;
        int numOfLetters = 0;
        int numOfCalls = 0;
        int numOfStrings = 0;
        char stopChar = 'a';
        public Unit2Smp3Form()
        {
            InitializeComponent();
        }
        private void GenStrings(int position)
        {
            char ch;

            numOfCalls++;

            if (position == stringLength)
            {
                PrintCharArray();
                numOfStrings++;
            }
            else
            {
                for (ch = 'a'; ch <= stopChar; ch++)
                {
                    charArray[position] = ch;
                    GenStrings(position + 1);
                }
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            int i;

            numOfCalls = 0;
            numOfStrings = 0;

            stringLength = int.Parse(lengthTextBox.Text);
            numOfLetters = int.Parse(numLettersTextBox.Text);
            charArray = new char[stringLength];

            outputTextbox.Clear();

            stopChar = 'a';
            for (i = 1; i < numOfLetters; i++)
            {
                stopChar++;
            }

            GenStrings(0);

            recursiveCallsTextBox.Text = numOfCalls.ToString();
            numStringsTextBox.Text = numOfStrings.ToString();
        }
        private void PrintCharArray()
        {
            string stringToPrint = "";
            int i;

            for( i = 0; i < stringLength; i++)
            {
                stringToPrint += charArray[i];

            }
            outputTextbox.Text += stringToPrint;
            outputTextbox.Text += System.Environment.NewLine;
        }
    }
}