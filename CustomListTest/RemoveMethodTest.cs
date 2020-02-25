using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void Remove_OneValue_DecrementCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 0;
            int firstValue = 7;
            //Act
            myList.Add(firstValue);
            myList.Remove(firstValue);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }

        [TestMethod]
        public void Remove_OneValue_InsertToFirstIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 7;
            int firstValue = 4;
            int secondValue = 7;

            //Act
            myList.Add(firstValue);
            myList.Add(secondValue);
            myList.Remove(firstValue);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }

        [TestMethod]
        public void Remove_OneValue_GetSecondIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 7;
            int firstValue = 4;
            int secondValue = 11;
            int thirdValue = 7;

            //Act
            myList.Add(firstValue);
            myList.Add(secondValue);
            myList.Add(thirdValue);
            myList.Remove(firstValue);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Remove_OneValue_GetCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 8;
            int firstValue = 7;
            int secondValue = 11;
            int thirdValue = 24;
            int fourthValue = 32;
            int fifthValue = 44;

            //Act
            myList.Add(firstValue);
            myList.Add(secondValue);
            myList.Add(thirdValue);
            myList.Add(fourthValue);
            myList.Add(fifthValue);
            myList.Remove(thirdValue);

            //Assert
            Assert.AreEqual(expected, myList.Capacity);

        }

        [TestMethod]
        public void Remove_TwoValues_GetCapacity()
        {
            //Arramge
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int firstValue = 7;
            int secondValue = 11;

            //Act
            myList.Add(firstValue);
            myList.Add(secondValue);
            myList.Remove(firstValue);
            myList.Remove(secondValue);

            //Assert
            Assert.AreEqual(expected, myList.Capacity);
        }
        [TestMethod]
        public void Remove_OneValue_KeepDuplicate()
        {
            //Arramge
            CustomList<int> myList = new CustomList<int>();
            int expected = 7;


            //Act
            myList.Add(3);
            myList.Add(7);
            myList.Add(5);
            myList.Add(7);
            myList.Remove(7);


            //Assert
            Assert.AreEqual(expected, myList[2]);
        }
    }

}
