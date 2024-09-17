
/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit2Prb1.cs                                   */
/*                                                          */
/*  Programmer:                                             */
/*                                                          */
/*  Purpose: Solve the water area problem with recursion    */
/*                                                          */
/************************************************************/

using LinkedQueueLib;

namespace Unit2Prb1
{
    public partial class Unit2Prb1Form : Form
    {

        const string INPUT_FILE_NAME = "MapData.txt";
        StreamReader fileIn;

        int numRows, numCols;
        int startRow, startCol;

        char[,] mapArray;

        public Unit2Prb1Form()
        {
            InitializeComponent();
        }

        private int Area(int row, int col)
        {
            int result = 0;

            if (mapArray[row][col] == '.' || mapArray[row][col] == '#')
            {
                return 0;
            }
            else
            {
                result = 1;
                mapArray[row][col] = '#';
                if (row > 0)
                {
                    result += Area(row - 1, col);
                }
                if (row < numRows - 1)
                {
                    result += Area(row + 1, col);
                }
                if (col > 0)
                {
                    result += Area(row, col - 1);
                }
                if (col < numCols - 1)
                {
                    result += Area(row, col + 1);
                }
            }

            return result;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            LoadMap();
            PrintMap();
            areaTextBox.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            LoadMap();

            startRow = int.Parse(rowTextBox.Text);
            startCol = int.Parse(columnTextBox.Text);

            if ((startRow >= 0) && (startRow < numRows) && (startCol >= 0) && (startCol < numCols))
            {
                areaTextBox.Text = Area(startRow, startCol).ToString();
            }
            else
            {
                MessageBox.Show("Invalid row and column location!", "Error");
            }

            PrintMap();
        }

        private void Unit2Prb1Form_Load(object sender, EventArgs e)
        {
            LoadMap();
            PrintMap();
        }

        private void LoadMap()
        {
            string lineIn;
            int i, j;

            fileIn = new StreamReader(INPUT_FILE_NAME);
            numRows = int.Parse(fileIn.ReadLine());
            numCols = int.Parse(fileIn.ReadLine());

            mapArray = new char[numRows, numCols];

            for (i = 0; i < numRows; i++)
            {
                lineIn = fileIn.ReadLine();
                for (j = 0; j < numCols; j++)
                {
                    mapArray[i, j] = lineIn[j];
                }
            }

            fileIn.Close();
        }
        private void PrintMap()
        {
            int i, j; 
            string lineToPrint = "";

            mapTextBox.Clear();

            for (i = 0; i < numRows; i++)
            {
                lineToPrint = "";

                for (j = 0; j < numCols; j++)
                {
                    lineToPrint += mapArray[i, j];
                }

                mapTextBox.Text += lineToPrint;
                mapTextBox.Text += System.Environment.NewLine;               
            }
        }
    }
}