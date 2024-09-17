/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Smp6.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Produce all possible binary strings of         */
/*           given length with specific number of 1s        */
/*           Uses a pruning approach for efficiency  .      */
/*                                                          */
/************************************************************/

namespace Unit2Smp6
{
    public partial class Unit2Smp6Form : Form
    {

        int[] binaryArray;
        int stringLength = 0;
        int weight = 0;
        int numOfCalls = 0;
        int numOfStrings = 0;
        public Unit2Smp6Form()
        {
            InitializeComponent();
        }

        private void GenStrings(int position, int currentWeight)
        {
            numOfCalls++;

            if (position == stringLength)
            {

                PrintCharArray();
                numOfStrings++;

            }
            else
            {
                // Append a 0 only if we still have enough slots for 1s to reach target weight
                if (stringLength - position + 1 + currentWeight > weight)
                {
                    binaryArray[position] = 0;
                    GenStrings(position + 1, currentWeight);
                }

                // Append a 1 only if adding it won't exceed our target weight
                if (currentWeight < weight)
                {
                    binaryArray[position] = 1;
                    GenStrings(position + 1, currentWeight + 1);
                }
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            int i;

            numOfCalls = 0;
            numOfStrings = 0;

            stringLength = int.Parse(lengthTextBox.Text);
            weight = int.Parse(weightTextBox.Text);
            binaryArray = new int[stringLength];

            outputTextbox.Clear();

            GenStrings(0,0);

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