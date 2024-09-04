/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: ArrayStackLib.cs                               */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Create ArrayStackLib namespace library (DLL).  */
/*           Constains definition of class ArrayStack       */
/*                                                          */
/************************************************************/

// Begin namespace ArrayStackLib

namespace ArrayStackLib
{
    // Begin class ArrayStack

    public class ArrayStack
    {
        const int DEFAULT_LENGTH = 0;
        const int INCREMENT = 5;      // The underlying array will be resized in blocks of whatever INCREMENT is


        private string name;
        private int count;
        private object[] array;

        public ArrayStack() //Default constructor
        {
            this.name = "Array Stack";
            this.count = 0;
            this.array = new object[DEFAULT_LENGTH];
        }

        public ArrayStack(string nameValue) // Initializing constructor
        {
            this.name = nameValue;
            this.count = 0;
            this.array = new object[DEFAULT_LENGTH];
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

        public object[] List // Define read-only List proprty
        {
            get
            {
                return this.array;
            }
        }

        public bool Empty // Return true (false) if the stack is (not) empty
        {
            get
            {
                return (this.count == 0);
            }
        }

        public void Purge() // Remove all data from stack
        {
            this.count = 0;
            this.array = new object[DEFAULT_LENGTH];
        }

        public void Push(object data) // Push an object onto the stack
        {
            // Check if we need to resize the array
            if (this.count == this.array.Length)
            {
                this.Expand();
            }

            this.array[this.count] = data;
            this.count++;
        }
        public object Pop() // Pop an object from the stack
        {
            object data = null;

            if (this.count > 0)
            {
                data = this.array[this.count - 1];

                this.count--;

                if (this.count <= this.array.Length - INCREMENT)
                {
                    this.Shrink();
                }
                else
                {
                    this.array[this.count] = null;
                }    
            }
            return data;
        }

        private void Expand()
        {
           object[]  newArray = new object[this.array.Length + INCREMENT];
           int i;
           
           for (i = 0; i < this.count; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
        }

        private void Shrink()
        {
            object[] newArray = new object[this.array.Length - INCREMENT];
            int i;

            for (i = 0; i < this.count; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
        }

        public object Peek() // Return the next object to be popped, but do *not* remove it from the stack
        {
            object data = null;

            if (this.count > 0)
            {
                data = this.array[this.count - 1];
            }

            return data;
        }
    }

 }