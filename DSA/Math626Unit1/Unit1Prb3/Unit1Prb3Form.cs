/********************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Prb3.cs                                   */
/*                                                          */
/*  Programmer:                                             */
/*                                                          */
/*  Purpose: Using a stack, implement an infix to postfix   */
/*           expression parser. +,-,*,/,^ are supported.    */
/*           Given values for a,b,c,d, evaluate the postfix */
/*           expression.                                    */
/*                                                          */
/********************/

using ArrayStackLib;

namespace Unit1Prb3
{
    public partial class Unit1Prb3Form : Form
    {
        private ArrayStack operatorStack = new ArrayStack("Operator Stack");
        private string infixStr;
        private string postfixStr;

        private double a = 0.0, b = 0.0, c = 0.0, d = 0.0;
        private ArrayStack operandStack = new ArrayStack("Operand Stack");
        private double expressionValue = 0.0;

        public Unit1Prb3Form()
        {
            InitializeComponent();
        }

        private int InfixPriority(char infixOperator)
        {
            int priority = 0;

            switch (infixOperator)
            {
                case '(': priority = 4; break;
                case '^': priority = 3; break;
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
                case '^': priority = 3; break;
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
                    while ((char)topCh != '(')
                    {
                        postfixStr += topCh;
                        topCh = (char)operatorStack.Pop();

                    }
                }
                else
                {
                    keepPopping = true;

                    while (!operatorStack.Empty && keepPopping)
                    {
                        topCh = (char)operatorStack.Peek();

                        if ((StackPriority(topCh) >= InfixPriority(infixCh))
                            && !(topCh == '^' && infixCh == '^'))
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
                postfixStr += (char)operatorStack.Pop();
            }
            return postfixStr;
        }

        private double EvaluatePostfix()
        {
            char postfixCh;
            double operand1, operand2, result = 0.0;

            operandStack.Purge();

            for (int i = 0; i < postfixStr.Length; i++)
            {
                postfixCh = postfixStr[i];

                if (Char.IsLetter(postfixCh))
                {
                    switch (postfixCh)
                    {
                        case 'a': operandStack.Push(a); break;
                        case 'b': operandStack.Push(b); break;
                        case 'c': operandStack.Push(c); break;
                        case 'd': operandStack.Push(d); break;
                        default: throw new Exception("Unknown variable");
                    }
                }
                else
                {
                    operand1 = (double)operandStack.Pop();
                    operand2 = (double)operandStack.Pop();

                    switch (postfixCh)
                    {
                        case '+': result = operand2 + operand1; break;
                        case '-': result = operand2 - operand1; break;
                        case '*': result = operand2 * operand1; break;
                        case '/':
                            if (operand1 == 0)
                                throw new DivideByZeroException("Division by zero");
                            result = operand2 / operand1;
                            break;
                        case '^': result = Math.Pow(operand2, operand1); break;
                        default: throw new Exception("Unknown operator");
                    }

                    operandStack.Push(result);
                }
            }

            expressionValue = (double)operandStack.Pop();
            return expressionValue;
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

            try
            {
                if (postfixStr != "")
                {
                    a = double.Parse(aTextBox.Text);
                    b = double.Parse(bTextBox.Text);
                    c = double.Parse(cTextBox.Text);
                    d = double.Parse(dTextBox.Text);

                    expressionValue = Math.Round(EvaluatePostfix(), 3);
                    valueTextBox.Text = expressionValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in evaluating postfix expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                infixTextBox.Focus();
            }
        }

    }


}