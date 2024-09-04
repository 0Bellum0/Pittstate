/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Smp2.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Test ArrayStackLib with simple save/undo       */
/*             changes application                          */
/*                                                          */
/************************************************************/

using ArrayStackLib;

namespace Unit1Smp2
{
    public partial class Unit1Smp2Form : Form
    {
        private ArrayStack changeLog = new ArrayStack("Change Log");

        public Unit1Smp2Form()
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
            logTextBox.Clear();
            stackLengthTextBox.Clear();

            stackLengthTextBox.Text = changeLog.Count.ToString();

            int i;

            for (i = 0; i < changeLog.Count; i++)
            {
                logTextBox.Text += changeLog.List[i];
                logTextBox.Text += System.Environment.NewLine;

            }

        }
    }
}