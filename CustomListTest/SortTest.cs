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
        [TestMethod]
        public void Sort_StringList_GetResult()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>() { "cat", "dog", "rabbit", "bear"};
            CustomList<string> expected = new CustomList<string>() { "bear", "cat", "dog", "rabbit" };


            //Act
            stringList.Sort(stringList);
            //Assert
            Assert.AreEqual(expected.ToString(), stringList.ToString());
        }
        [TestMethod]
        public void Sort_StringList_GetResultTwo()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>() { "A", "B", "a", "b" };
            CustomList<string> expected = new CustomList<string>() { "A","a","B","b" };


            //Act
            stringList.Sort(stringList);
            //Assert
            Assert.AreEqual(expected.ToString(), stringList.ToString());
        }
        [TestMethod]
        public void Sort_CharList_GetResult()
        {
            //Arrange
            CustomList<char> charList = new CustomList<char>() { 'A', 'Z', 'b' ,'e' };
            CustomList<char> expected = new CustomList<char>() { 'A', 'Z', 'b' ,'e'};


            //Act
            charList.Sort(charList);
            //Assert
            Assert.AreEqual(expected.ToString(), charList.ToString());
        }
        [TestMethod]
        public void Sort_CharList_GetResultTwo()
        {
            //Arrange
            CustomList<char> charList = new CustomList<char>() { 'A', 'Z', 'b', 'e', 'a', 'z' };
            CustomList<char> expected = new CustomList<char>() { 'A', 'Z', 'a', 'b', 'e', 'z' };


            //Act
            charList.Sort(charList);
            //Assert
            Assert.AreEqual(expected.ToString(), charList.ToString());
        }
    }
}
