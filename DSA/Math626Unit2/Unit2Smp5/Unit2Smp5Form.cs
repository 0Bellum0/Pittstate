
/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Smp5.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Produce all possible binary strings of         */
/*           given length with specific number of 1s        */  
/*           Uses a brtue force approach.                   */
/*                                                          */
/************************************************************/

namespace Unit2Smp5
{
    public partial class Unit2Smp5Form : Form
    {
        int[] binaryArray;
        int stringLength = 0;
        int weight = 0;
        int numOfCalls = 0;
        int numOfStrings = 0;
        public Unit2Smp5Form()
        {
            InitializeComponent();
        }
        private void GenStrings(int position)
        {
            numOfCalls++;

            if (position == stringLength)
            {
                if (WeightCalc() == weight)
                {
                    PrintCharArray();
                    numOfStrings++;
                }
            }
            else
            {
                binaryArray[position] = 0;
                GenStrings(position + 1);

                binaryArray[position] = 1;
                GenStrings(position + 1);
            }
        }

        // Calculate weight of binaryArray
        private int WeightCalc()
        {
            int i, w = 0;

            for (i = 0; i < stringLength; i++)
            {
                w += binaryArray[i];

            }
            return w;
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            numOfCalls = 0;
            numOfStrings = 0;

            stringLength = int.Parse(lengthTextBox.Text);
            weight = int.Parse(weightTextBox.Text);
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