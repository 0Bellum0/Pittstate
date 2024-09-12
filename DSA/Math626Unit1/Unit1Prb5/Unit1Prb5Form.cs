/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Prb5.cs                                   */
/*                                                          */
/*  Programmer:                                             */
/*                                                          */
/*  Purpose: Test LinkedQueueLib with simple job queue      */
/*           application                                    */
/*                                                          */
/************************************************************/
using LinkedQueueLib;

namespace Unit1Prb5
{

    public partial class Unit1Prb5Form : Form
    {
        public LinkedQueue jobQueue = new LinkedQueue("Job Queue");
        public Unit1Prb5Form()
        {
            InitializeComponent();
        }

        private void newJobButton_Click(object sender, EventArgs e)
        {
            
            Job newJob = new Job();
            addForm addDialog = new addForm();
            ;

            if (addDialog.ShowDialog()  == DialogResult.OK)
            {
                newJob.JobNumber = addDialog.returnJobNum;
                newJob.UserName = addDialog.returnUName;

                jobQueue.Enqueue(newJob);
            }

            PrintQueue();
            
        }

        private void releaseJobButton_Click(object sender, EventArgs e)
        {
            
            if (!jobQueue.Empty)
            {
                Job releasedJob;
                releasedJob = (Job)jobQueue.Dequeue();
                MessageBox.Show("Job number " + releasedJob.JobNumber.ToString() + " for " + releasedJob.UserName + " completed.");
                PrintQueue();
            }
            else
            {
                MessageBox.Show("Job queue is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private void PrintQueue()
        {
            QueueNode currentNode;
            Job currentJob;

            numTextBox.Text = jobQueue.Size.ToString();
            queueTextBox.Clear();

            currentNode = jobQueue.Peek();

            while (currentNode != null)
            {
                currentJob = (Job)currentNode.Data;
                queueTextBox.Text += currentJob.ToString();
                queueTextBox.Text += System.Environment.NewLine;
                currentNode = currentNode.Next;
            }
        }


    }
    public class Job
    {
        private int jobNumber;
        private string userName;

        public Job()
        {
            this.jobNumber = 0; this.userName = "";
        }

        public int JobNumber // Define read/write JobNumber property
        {
            get
            {
                return this.jobNumber;
            }
           
            set
            {
                this.jobNumber = value;
            }
        }

        public string UserName // Define read/write UserName property
        {
            get
            {
                return this.userName;
            }

            set
            {
                this.userName = value;
            }
        }

        public override string ToString()
        {
            return this.jobNumber.ToString() + ", " + this.userName;
        }
    }
}