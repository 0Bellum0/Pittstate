/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: LinkedStackLib.cs                              */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Create LinkedStackLib namespace library (DLL). */
/*           Constains definition of class LinkedStack      */
/*                                                          */
/************************************************************/

// Begin namespace LinkedStackLib

namespace LinkedStackLib
{
    // Begin class StackNode

    public class StackNode
    {
        private object data;
        private StackNode next;

        public StackNode(object dataValue)  // Initializing constructor
        {
            this.data = dataValue;
            this.next = null;
        }

        public object Data // Read-only Data property
        {
            get
            {
                return this.data;
            }
        }

        public StackNode Next //Read/write Next property
        {

            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    } // End class StackNode

    // Begin class LinkedStack

    public class LinkedStack
    {
        private string name;
        private int count;
        private StackNode top;

        public LinkedStack() //Default constructor
        {
            this.name = "Linked Stack";
            this.count = 0;
            this.top = new StackNode(null);
        }

        public LinkedStack(string nameValue) // Initializing constructor
        {
            this.name = nameValue;
            this.count = 0;
            this.top = new StackNode(null);
        }

        public string Name // Define read/write name property
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

        public int Count // Define read-only count proprty
        {
            get
            {
                return this.count;
            }
        }

        public bool Empty // Return true (false) if the Stack is (not) empty
        {
            get
            {
                return (this.count == 0);
            }
        }

        public void Purge() // Remove all data from Stack
        {
            this.count = 0;
            this.top = new StackNode(null);
        }

        public void Push(object data) // Push an object onto the stack
        {
            StackNode stackNode = new StackNode(data);

            stackNode.Next = this.top.Next;
            this.top.Next = stackNode;

            this.count++;
        }

        public object Pop() // Pop an object from the stack
        {
            object data = null;

            if (this.count > 0)
            {
                StackNode StackNode = new StackNode(data);

                data = this.top.Next.Data;
                this.top.Next = this.top.Next.Next;

                this.count--;

            }
            return data;

        }

        public StackNode Peek() // Return the next object to be deStackd, but do *not* remove it from the Stack
        {
            StackNode node = null;

            if (this.count > 0)
            {
                node = this.top.Next;
            }
            return node;

        }
    }

}
