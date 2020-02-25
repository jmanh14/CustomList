using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;
        private T[] newArray;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value; 
            }
        }

        public T this[int index] 
        {
            get
            {
                return newArray[index];
            }
            set
            {
                newArray[index] = value;
            }

        }

        public CustomList()
        {
            capacity = 4;
            newArray = new T[capacity];
        }

        public void Add(T item)
        {
            newArray[count] = item;
            //Increment Count
            count++;
            //Item needs to land at next available index           
            //Check to make sure it persists
            //If count == maxCapacity, we need to increase capacity and copy
            if (count == capacity)
            {
                capacity *= 2;
                T[] temporaryArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = newArray[i];
                }
                newArray = temporaryArray;
            }

        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (newArray[i].Equals(item))
                {
                    for (int j = i; j < count; j++)
                    {
                        newArray[j] = newArray[j + 1];
                    }
                    count--;
                    return;
                }

            }
            //Decrement Count

            //Item needs to shift to next index

            //Check to make sure it persists

        }
    }
}
