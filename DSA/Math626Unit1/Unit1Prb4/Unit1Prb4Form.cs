/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Prb4.cs                                   */
/*                                                          */
/*  Programmer:                                             */
/*                                                          */
/*  Purpose: Test ArrayQueueLib with simple work order      */
/*           application                                    */
/*                                                          */
/************************************************************/
using ArrayQueueLib;

namespace Unit1Prb4
{
    public partial class Unit1Prb4Form : Form
    {
        public ArrayQueue orderQueue = new ArrayQueue("Work order queue");
        public Unit1Prb4Form()
        {
            InitializeComponent();
        }

        private void newJobButton_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            addForm addDialog = new addForm();

            if (addDialog.ShowDialog() == DialogResult.OK)
            {
                newOrder.OrderNumber = addDialog.returnOrderNum;
                newOrder.Name = addDialog.returnName;

                orderQueue.Enqueue(newOrder);
            }

            PrintQueue();
        }

        private void releaseOrderButton_Click(object sender, EventArgs e)
        {
            if (!orderQueue.Empty)
            {
                Order releasedOrder = (Order)orderQueue.Dequeue();
                MessageBox.Show("Order number " + releasedOrder.OrderNumber.ToString() + " for " + releasedOrder.Name + " completed.");
                PrintQueue();
            }
            else
            {
                MessageBox.Show("The queue is empty.");
            }
        }

        private void PrintQueue()
        {
            queueTextBox.Clear();

            for (int i = 0; i < orderQueue.Size; i++)
            {
                Order currentOrder = (Order)orderQueue.List[(orderQueue.Front + i) % orderQueue.List.Length];
                queueTextBox.AppendText("Order " + currentOrder.OrderNumber + " - " + currentOrder.Name + Environment.NewLine);
            }
        }

    }
    public class Order
    {
        private int orderNumber;
        private string name;

        public Order()
        {
            this.orderNumber = 0; this.name = "";
        }

        public int OrderNumber // Define read/write Order Number property
        {
            get
            {
                return this.orderNumber;
            }

            set
            {
                this.orderNumber = value;
            }
        }

        public string Name // Define read/write UserName property
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
        public override string ToString()
        {
            return this.orderNumber.ToString() + ", " + this.name;
        }
    }
}