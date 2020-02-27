using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ZipperTest
    {
        [TestMethod]
        public void Zip_TwoIntList_GetResult()
        {
            //Arrange
            CustomList<int> numberListOne = new CustomList<int>() { 1,3,5};
            CustomList<int> numberListTwo = new CustomList<int>() { 2,4,6};
            CustomList<int> zippedList = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>() {1,2,3,4,5,6};
            
            //Act
            zippedList = zippedList.Zip(numberListOne,numberListTwo);

            //Assert
            Assert.AreEqual(expected.ToString(), zippedList.ToString());
        }
        [TestMethod]
        public void Zip_TwoIntList_GetResultTwo()
        {
            //Arrange
            CustomList<int> numberListOne = new CustomList<int>();
            CustomList<int> numberListTwo = new CustomList<int>();
            CustomList<int> zippedList = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);
            expected.Add(7);
            //Act
            numberListOne.Add(1);
            numberListOne.Add(3);
            numberListOne.Add(5);
            numberListOne.Add(7);
            numberListTwo.Add(2);
            numberListTwo.Add(4);
            numberListTwo.Add(6);
            zippedList = zippedList.Zip(numberListOne, numberListTwo);
            //Assert
            Assert.AreEqual(expected.ToString(), zippedList.ToString());
        }
        [TestMethod]
        public void Zip_TwoStringtList_GetResult()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> zippedList = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();
            expected.Add("A");
            expected.Add("B");
            expected.Add("C");
            expected.Add("D");
            expected.Add("E");
            expected.Add("F");
            //Act
            stringListOne.Add("A");
            stringListOne.Add("C");
            stringListOne.Add("E");
            stringListTwo.Add("B");
            stringListTwo.Add("D");
            stringListTwo.Add("F");
            zippedList = zippedList.Zip(stringListOne, stringListTwo);
            //Assert
            Assert.AreEqual(expected.ToString(), zippedList.ToString());
        }
        [TestMethod]
        public void Zip_TwoStringtList_GetResultTwo()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> zippedList = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();
            expected.Add("A");
            expected.Add("B");
            expected.Add("C");
            expected.Add("D");
            expected.Add("E");
            expected.Add("F");
            expected.Add("G");
            //Act
            stringListOne.Add("A");
            stringListOne.Add("C");
            stringListOne.Add("E");
            stringListOne.Add("G");
            stringListTwo.Add("B");
            stringListTwo.Add("D");
            stringListTwo.Add("F");
            zippedList = zippedList.Zip(stringListOne, stringListTwo);
            //Assert
            Assert.AreEqual(expected.ToString(), zippedList.ToString());
        }
    }
}
