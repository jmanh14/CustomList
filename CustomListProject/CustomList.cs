using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private int count = 0;
        private int capacity = 4;
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
                return this[index];
            }
            set
            {
                this[index] = value;
            }

        }

        public void Add(T item)
        {
            //Increment Count
            count++;
            //Item needs to land at next available index
            T[] newArray = new T[capacity];

            //Check to make sure it persists
            
            //If count == maxCapacity, we need to increase capacity and copy
            if(count == capacity)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];
                tempArray = newArray;
                newArray = tempArray;
            }

        }

        public void Remove(T item)
        {
            //Decrement Count

            //Item needs to shift to next index

            //Check to make sure it persists

            //If count != maxCapacity, we need to decrease capacity and copy
        }
    }
}
