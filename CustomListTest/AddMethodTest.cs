using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTest
    {
        [TestMethod]
        public void Add_OneValue_IncrementCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;

            //Act 
            myList.Add(7);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }

        [TestMethod]
        public void Add_SixValues_IncrementCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 6;
            int firstValue = 7;
            int secondValue = 11;
            int thirdValue = 24;
            int fourthValue = 32;
            int fifthValue = 44;
            int sixthValue = 59;

            //Act
            myList.Add(firstValue);
            myList.Add(secondValue);
            myList.Add(thirdValue);
            myList.Add(fourthValue);
            myList.Add(fifthValue);
            myList.Add(sixthValue);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }

        [TestMethod]
        public void Add_OneValue_InsertToFirstIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 7;

            //Act
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }

        [TestMethod]
        public void Add_TwoValues_GetSecondIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 11;
            int firstValue = 7;
            int secondValue = 11;

            //Act
            myList.Add(firstValue);
            myList.Add(secondValue);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }

        [TestMethod]
        public void Add_FiveValues_GetCapacity()
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

            //Assert
            Assert.AreEqual(expected, myList.Capacity);

        }
        [TestMethod]
        public void Add_FiveValues_GetIndexOfLastValue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 44;
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

            //Assert
            Assert.AreEqual(expected, myList[4]);

        }
        [TestMethod]
        public void Add_OneValue_GetCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int firstValue = 7;

            //Act
            myList.Add(firstValue);

            //Assert
            Assert.AreEqual(expected, myList.Capacity);
        }  
    }
}
