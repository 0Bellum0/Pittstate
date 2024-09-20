/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Prb2.cs                                   */
/*                                                          */
/*  Programmer:                                             */
/*                                                          */
/*  Purpose: Solve 0-1 Knapsack Problem with complete       */
/*           enumeration. Improved efficiency with          */
/*           pruning.                                       */
/*                                                          */
/************************************************************/

namespace Unit2Prb2
{
    public partial class Unit2Prb2Form : Form
    {
        int maxWeight;
        int numItems;
        int maxProfitFound;
        int optimalWeightFound;
        int numOfRecursiveCalls;

        int[] weightArray;
        int[] profitArray;
        int[] choiceArray; // 0 or 1 that signifies if an object is selected or not
        int[] optimalArray;

        string defaultDataFile = "KnapsackData.txt";
        StreamReader fileIn;

        public Unit2Prb2Form()
        {
            InitializeComponent();
        }

        private void LoadDataArrays(string dataFileName)
        {
            int i, j;

            fileIn = new StreamReader(dataFileName);

            maxWeight = int.Parse(fileIn.ReadLine());
            numItems = int.Parse(fileIn.ReadLine());

            fileIn.ReadLine(); // Read line to skip

            weightArray = new int[numItems];
            profitArray = new int[numItems];
            choiceArray = new int[numItems];
            optimalArray = new int[numItems];

            for (i = 0; i < numItems; i++)
            {
                weightArray[i] = int.Parse(fileIn.ReadLine());
            }

            fileIn.ReadLine(); // Read line to skip

            for (i = 0; i < numItems; i++)
            {
                profitArray[i] = int.Parse(fileIn.ReadLine());
            }
        }
        private void GenProfits(int position)
        {
            int weight, profit;

            numOfRecursiveCalls++;

            if (position == numItems)
            {
                weight = CalcWeight();
                profit = CalcProfit();

                if (weight <= maxWeight)
                {
                    if (profit > maxProfitFound)
                    {
                        maxProfitFound = profit;
                        optimalWeightFound = weight;
                        CopyChoice();
                    }
                }
            }
            else
            {
                // Do take the item
                choiceArray[position] = 1;
                GenProfits(position + 1);

                //Do not take the item
                choiceArray[position] = 0;
                GenProfits(position + 1);
            }
        }
        private void CopyChoice()
        {
            int i;

            for (i = 0; i < numItems; i++)
            {
                optimalArray[i] = choiceArray[i];
            }
        }

        private int CalcWeight()
        {
            int i, result = 0;

            for (i = 0; i < numItems; i++)
            {
                result += choiceArray[i] * weightArray[i];
            }

            return result;
        }

        private int CalcProfit()
        {
            int i, result = 0;

            for (i = 0; i < numItems; i++)
            {
                result += choiceArray[i] * profitArray[i];
            }

            return result;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int i;
            maxProfitFound = 0;

            for (i = 0; i < numItems; i++)
            {
                choiceArray[i] = 0;
                optimalArray[i] = 0;
            }

            numOfRecursiveCalls = 0;
            GenProfits(0);

            PrintOptimalData();
        }

        private void PrintKnapsackData()
        {
            int i;
            string stringToPrint;

            knapsackTextBox.Clear();

            knapsackTextBox.Text += "Item  Weight  Profit";
            knapsackTextBox.Text += System.Environment.NewLine;
            knapsackTextBox.Text += "--------------------";
            knapsackTextBox.Text += System.Environment.NewLine;

            for (i = 0; i < numItems; i++)
            {
                stringToPrint = String.Format("{0,2} {1, 8} {2, 8}", i, weightArray[i], profitArray[i]);
                knapsackTextBox.Text += stringToPrint;
                knapsackTextBox.Text += System.Environment.NewLine;
            }

            maxWeightTextBox.Text = maxWeight.ToString();
            optimalTextBox.Clear();
            maxProfitTextBox.Clear();
            solWeightTextBox.Clear();
            recursiveCallsTextBox.Clear();
        }

        private void PrintOptimalData()
        {
            int i;
            string stringToPrint;

            optimalTextBox.Clear();

            optimalTextBox.Text += "Item    Include(Y/N)";
            optimalTextBox.Text += System.Environment.NewLine;
            optimalTextBox.Text += "--------------------";
            optimalTextBox.Text += System.Environment.NewLine;

            for (i = 0; i < numItems; i++)
            {
                stringToPrint = String.Format("{0,2} {1, 16}", i, optimalArray[i]);
                optimalTextBox.Text += stringToPrint;
                optimalTextBox.Text += System.Environment.NewLine;
            }

            solWeightTextBox.Text = optimalWeightFound.ToString();
            maxProfitTextBox.Text = maxProfitFound.ToString();
            recursiveCallsTextBox.Text = numOfRecursiveCalls.ToString();
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadDataArrays(dialog.FileName);
                PrintKnapsackData();
            }
        }

        private void Unit2Prb2Form_Load(object sender, EventArgs e)
        {
            LoadDataArrays(defaultDataFile);
            PrintKnapsackData();
        }
    }
}