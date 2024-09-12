/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: ArrayQueueLib.cs                               */
/*                                                          */
/*  Programmer:                                             */
/*                                                          */
/*  Purpose: Create ArrayQueueLib namespace library (DLL).  */
/*           Constains definition of class ArrayQueue       */
/*                                                          */
/************************************************************/

using System;

public class ArrayQueue
{
    private string name;
    private int size;
    private object[] array;
    private const int INCREMENT = 10;
    private int front;
    private int rear;

    public ArrayQueue()
    {
        name = "DefaultQueue";
        size = 0;
        array = new object[INCREMENT];
        front = 0;
        rear = -1;
    }

    public ArrayQueue(string name)
    {
        this.name = name;
        size = 0;
        array = new object[INCREMENT];
        front = 0;
        rear = -1;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Size
    {
        get { return size; }
    }

    public object[] List
    {
        get { return array; }
    }

    public bool Empty
    {
        get { return size == 0; }
    }

    public void Purge()
    {
        size = 0;
        array = new object[INCREMENT];
        front = 0;
        rear = -1;
    }

    public void Enqueue(object data)
    {
        if (size == array.Length)
        {
            Resize();
        }

        rear = (rear + 1) % array.Length;
        array[rear] = data;
        size++;
    }

    public object Dequeue()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        object data = array[front];
        array[front] = null;
        front = (front + 1) % array.Length;
        size--;

        return data;
    }

    public object Peek()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return array[front];
    }

    private void Resize()
    {
        object[] newArray = new object[array.Length + INCREMENT];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[(front + i) % array.Length];
        }
        array = newArray;
        front = 0;
        rear = size - 1;
    }
}
