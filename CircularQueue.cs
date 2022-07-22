using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Queue
{
    internal class CircularQueue
    { 
        int[] arr;
        int front, rear, maxSize;
        public CircularQueue(int maxSize)
        {
            arr = new int[maxSize];
            front = -1;
            rear = -1;
            this.maxSize = maxSize;
        }
        public bool Add(int val)
        {
            if(front==-1 && rear==-1)
            {
                front++;
                rear++;
                arr[front] = val;
            }
            else 
            {
                if (front == ((rear + 1) % maxSize))
                {
                    return false;
                }
                rear = (rear + 1) % maxSize;
                arr[rear] = val;
            }
            return true;
        }
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
