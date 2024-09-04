/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Smp4.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Test LinkedStackLib with simple save/undo      */
/*           changes application                            */
/*                                                          */
/************************************************************/


using LinkedStackLib;

namespace Unit1Smp4
{
    public partial class Unit1Smp4Form : Form
    {

        private LinkedStack changeLog = new LinkedStack("Change Log");

        public Unit1Smp4Form()
        {
            InitializeComponent();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            changeLog.Push(editTextBox.Text);
            PrintStack();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            string poppedString;
            
            if (changeLog.Count > 0)
            {
                poppedString = changeLog.Pop().ToString();
                editTextBox.Text = poppedString;
                PrintStack();
            }
        }

        private void PrintStack()
        {
            StackNode currentNode;
            String currentString;

            stackLengthTextBox.Text = changeLog.Count.ToString();

            logTextBox.Clear();

            currentNode = changeLog.Peek();

            while (currentNode != null)
            {
                currentString= (String)currentNode.Data;
                logTextBox.Text += currentString;
                logTextBox.Text += System.Environment.NewLine;
                currentNode = currentNode.Next;
            }

        }
    }
}