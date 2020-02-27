using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class SubtractOperatorTest
    {
        [TestMethod]
        public void Subtract_TwoIntLists_GetResult()
        {
            //Arrange
            CustomList<int> numberListOne = new CustomList<int>();
            CustomList<int> numberListTwo = new CustomList<int>();
            CustomList<int> splitList;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(2);
            expected.Add(3);

            //Act
            numberListOne.Add(1);
            numberListOne.Add(2);
            numberListOne.Add(3);
            numberListTwo.Add(1);
            numberListTwo.Add(5);
            numberListTwo.Add(6);
            splitList = numberListOne - numberListTwo;

            //Assert
            Assert.AreEqual(expected.ToString(), splitList.ToString());
        }
        [TestMethod]
        public void Subtract_TwoStringLists_GetResult()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> combinedList;
            CustomList<string> expected = new CustomList<string>();
            expected.Add("B");
            expected.Add("C");

            //Act
            stringListOne.Add("A");
            stringListOne.Add("B");
            stringListOne.Add("C");
            stringListOne.Add("A");
            stringListTwo.Add("A");
            stringListTwo.Add("E");
            stringListTwo.Add("F");
            combinedList = stringListOne - stringListTwo;

            //Assert
            Assert.AreEqual(expected.ToString(), combinedList.ToString());
        }
        [TestMethod]
        public void Subtract_TwoEmptyList_GetResult()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> combinedList;
            CustomList<string> expected = new CustomList<string>();

            //Act
            combinedList = stringListOne - stringListTwo;

            //Assert
            Assert.AreEqual(expected.ToString(), combinedList.ToString());
        }
        [TestMethod]
        public void Subtract_TwoIntListsTwo_GetResult()
        {
            //Arrange
            CustomList<int> numberListOne = new CustomList<int>();
            CustomList<int> numberListTwo = new CustomList<int>();
            CustomList<int> splitList;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(2);
            expected.Add(3);

            //Act
            numberListOne.Add(1);
            numberListOne.Add(2);
            numberListOne.Add(3);
            numberListOne.Add(1);
            numberListTwo.Add(1);
            numberListTwo.Add(5);
            numberListTwo.Add(6);
            splitList = numberListOne - numberListTwo;

            //Assert
            Assert.AreEqual(expected.ToString(), splitList.ToString());
        }
    }
}
