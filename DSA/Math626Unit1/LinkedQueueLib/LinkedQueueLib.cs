/************************************************************/
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*  Program: LinkedQueueLib.cs                              */
/*  Programmer:                                             */
/*  Purpose: Create LinkedQueueLib namespace library (DLL). */
/*           Contains definition of class LinkedQueue       */
/************************************************************/

namespace LinkedQueueLib
{
    // Define QueueNode class
    public class QueueNode
    {
        public object Data { get; set; }
        public QueueNode Next { get; set; }

        public QueueNode(object data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    // Define LinkedQueue class
    public class LinkedQueue
    {
        private string name;
        private int size;
        private QueueNode head;
        private QueueNode tail;

        public LinkedQueue()
        {
            this.name = "Default Linked Queue";
            this.size = 0;
            this.head = null;
            this.tail = null;
        }

        public LinkedQueue(string name)
        {
            this.name = name;
            this.size = 0;
            this.head = null;
            this.tail = null;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Size
        {
            get { return this.size; }
        }

        public bool Empty
        {
            get { return this.size == 0; }
        }

        public void Purge()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public void Enqueue(object data)
        {
            QueueNode newNode = new QueueNode(data);
            if (this.tail != null)
            {
                this.tail.Next = newNode;
            }
            this.tail = newNode;

            if (this.head == null)
            {
                this.head = newNode;
            }
            this.size++;
        }

        public object Dequeue()
        {
            if (this.head == null)
            {
                return null;
            }

            object dequeuedData = this.head.Data;
            this.head = this.head.Next;

            if (this.head == null)
            {
                this.tail = null;
            }

            this.size--;
            return dequeuedData;
        }

        public QueueNode Peek()
        {
            return this.head;
        }
    }
}
