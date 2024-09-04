/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Smp3.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Using a stack, implement an infix to postfix   */
/*           expression parser. +,-,*,/ are supported.      */
/*                                                          */
/************************************************************/

using ArrayStackLib;

namespace Unit1Smp3
{
    public partial class Unit1Smp3Form : Form
    {
        private ArrayStack operatorStack = new ArrayStack("Operator Stack");
        private string infixStr;
        private string postfixStr;
        public Unit1Smp3Form()
        {
            InitializeComponent();
        }

        private int InfixPriority(char infixOperator)
        {
            int priority = 0;

            switch (infixOperator)
            {
                case '(': priority = 3; break;
                case '*': case '/': priority = 2; break;
                case '+': case '-': priority = 1; break;
                case ')': priority = 0; break;
            }
            return priority;
        }
        private int StackPriority(char stackOperator)
        {
            int priority = 0;

            switch (stackOperator)
            {
                case '*': case '/': priority = 2; break;
                case '+': case '-': priority = 1; break;
                case '(': priority = 0; break;
            }
            return priority;
        }
        private string ParseInfixExpression(string infixStr)
        {
            int i;
            char infixCh = ' ', topCh = ' ';
            bool keepPopping;
            string postfixStr = "";

            operatorStack.Purge();

            for (i = 0; i <= infixStr.Length - 1; i++)
            {
                infixCh = infixStr[i];

                if (Char.IsLetter(infixCh))
                {
                    postfixStr += infixCh;
                }

                else if (infixCh == ')')
                {
                    topCh = (char)operatorStack.Pop();
                    while ((char) topCh != '(')
                    {
                        postfixStr += topCh;
                        topCh = (char) operatorStack.Pop();

                    }
                }
                else
                {
                    keepPopping = true;

                    while(!operatorStack.Empty && keepPopping)
                    {
                        topCh = (char) operatorStack.Peek();

                        if (StackPriority(topCh) >= InfixPriority(infixCh))
                        {
                            operatorStack.Pop();
                            postfixStr += topCh;
                        }
                        else
                        {
                            keepPopping = false;
                        }
                    }
                    operatorStack.Push(infixCh);
                }

            }

            while (!operatorStack.Empty)
            {
                postfixStr += (char) operatorStack.Pop();
            }
            return postfixStr;
        }

        private void parseButton_Click(object sender, EventArgs e)
        {
            infixStr = infixTextBox.Text;

            try
            {
                postfixStr = ParseInfixExpression(infixStr);
                postfixTextBox.Text = postfixStr;
            }
            catch
            {
                MessageBox.Show("Error in infix expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                infixTextBox.Focus(); 
            }
        }

     
    }


}