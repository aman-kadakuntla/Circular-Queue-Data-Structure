using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Queue
{
    internal class CircularQueue
    { 
        int[] arr;//array to store the elements
        int front, rear, maxSize;
        
        //constructor accepts the maximum size of the array and initialises the variables
        public CircularQueue(int maxSize)
        {
            arr = new int[maxSize];
            front = -1;
            rear = -1;
            this.maxSize = maxSize;
        }

        // add function takes an integer parameter, adds the element into the array and return a bool value
        public bool Add(int val)
        {
            if(front==-1 && rear==-1)// checks if the array is empty
            {
                front++;
                rear++;
                arr[front] = val;// first element is added into the array
            }
            else 
            {
                if (front == ((rear + 1) % maxSize))
                {
                    return false;// returns false if array is full
                }
                rear = (rear + 1) % maxSize;
                arr[rear] = val;
            }
            return true;
        }
        // delete function removes the first element i.e the front values will be changed 
        public bool Delete()
        {
            if (front == maxSize - 1 && rear== maxSize-1)
            {
                front = -1; rear = -1;
            }
            else if(front==-1&& rear==-1)
            {
                return false;
            }
            else if (front == rear)
            {
                front = -1; rear = -1;
            }
            else 
            {
                front=(front + 1)%maxSize;
            }
            return true;
        }
        
        //returns all the elements.
        public List<int> display()
        {
            List<int> list = new List<int>();
            if (front == -1 || rear == -1)
                return list;
            int i = front;
            while(i!=rear)
            {
                list.Add(arr[i]);
                i = (i + 1) % maxSize;
            }
            list.Add(arr[rear]);
            return list;
        }
    }
}
