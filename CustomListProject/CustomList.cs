using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < newArray.Length; index++)
            {
                yield return newArray[index];
            }
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

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString += newArray[i].ToString();
            }
            return newString;
        }
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> resultList = new CustomList<T>();
            for(int i = 0; i < listOne.count; i++)
            {
                resultList.Add(listOne[i]);
            }
            for(int i = 0; i < listTwo.count; i++)
            {
                resultList.Add(listTwo[i]);
            }
            return resultList;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> resultList = new CustomList<T>();
            //resultList = listOne;
            for (int i = 0; i < listOne.count; i++)
            {
                bool isInList = false;
                for (int j = 0; j < listTwo.count; j++)
                {
                    
                    if (listOne[i].Equals(listTwo[j]))
                    { 
                        isInList = true;
                    }
                    if ((j == listTwo.count - 1) && isInList != true)
                    {
                        resultList.Add(listOne[i]);
                    }              
                }
              
            }
            return resultList;
        }

        public CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> resultList = new CustomList<T>();
            //if(listOne.count != listTwo.count)
            //{
            //    for (int i = 0; i < listOne.count; i++)
            //    {
            //        resultList.Add(listOne[i]);
            //        if(i != listOne.count - 1 )
            //        {
            //            resultList.Add(listTwo[i]);
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < listOne.count; i++)
            //    {
            //        resultList.Add(listOne[i]);
            //        resultList.Add(listTwo[i]);
            //    }
            //}

            for (int i = 0; i < (listOne.count >= listTwo.count ? listOne.count : listTwo.count); i++)
            {
                if (listOne.count > i)
                    resultList.Add(listOne[i]);

                if (listTwo.count > i)
                    resultList.Add(listTwo[i]);
            }
            return resultList;
         
        }
        public void Sort(CustomList<int> listOne)
        {
            for (int i = 0; i <= listOne.count - 2; i++)
            { 
                for (int j = 0; j <= listOne.count - 2; j++)
                {
                    if (listOne[j] > listOne[j + 1])
                    {
                        int temporary = listOne[j];
                        listOne[j] = listOne[j + 1];
                        listOne[j + 1] = temporary;
                    }
                }            
            }
        }      
    }
}
