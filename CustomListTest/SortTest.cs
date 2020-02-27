using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace CustomListTest
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Sort_IntList_GetResult()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>() { 1, 3, 2, 4, 6, 5, 8, 7, 9 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //Act
            numberList.Sort(numberList);
            //Assert
            Assert.AreEqual(expected.ToString(), numberList.ToString());
        }
        [TestMethod]
        public void Sort_IntList_GetResultTwo()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>() { 70, 22, 34, 35, 69, 11 };
            CustomList<int> expected = new CustomList<int>() { 11, 22, 34, 35, 69, 70 };


            //Act
            numberList.Sort(numberList);
            //Assert
            Assert.AreEqual(expected.ToString(), numberList.ToString());
        }
        [TestMethod]
        public void Sort_IntList_GetResultThree()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>() { 1,2,3,5,4,6,7,8,9 };
            CustomList<int> expected = new CustomList<int>() { 1,2,3,4,5,6,7,8,9 };


            //Act
            numberList.Sort(numberList);
            //Assert
            Assert.AreEqual(expected.ToString(), numberList.ToString());
        }
    }
}
