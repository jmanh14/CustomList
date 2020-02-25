using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class AddOperatorTest
    {
        [TestMethod]
        public void Add_TwoIntLists_GetResult()
        {
            //Arrange
            CustomList<int> numberListOne = new CustomList<int>();
            CustomList<int> numberListTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);

            //Act
            numberListOne.Add(1);
            numberListOne.Add(2);
            numberListOne.Add(3);
            numberListTwo.Add(4);
            numberListTwo.Add(5);
            numberListTwo.Add(6);
            resultList = numberListOne + numberListTwo;

            //Assert
            Assert.AreEqual(expected, resultList);
        }
        [TestMethod]
        public void Add_TwoStringLists_GetResult()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> resultList = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();
            expected.Add("B");
            expected.Add("C");
            expected.Add("D");
            expected.Add("E");
            expected.Add("F");

            //Act
            stringListOne.Add("A");
            stringListOne.Add("B");
            stringListOne.Add("C");
            stringListTwo.Add("D");
            stringListTwo.Add("E");
            stringListTwo.Add("F");
            resultList = stringListOne + stringListTwo;

            //Assert
            Assert.AreEqual(expected, resultList);
        }
        [TestMethod]
        public void Add_TwoEmptyList_GetResult()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> resultList = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();

            //Act
            resultList = stringListOne + stringListTwo;

            //Assert
            Assert.AreEqual(expected, resultList);
        }
    }
}
