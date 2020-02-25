using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void Convert_NumberList_ToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int> ();
            string expected = "1234";

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(34);

            //Assert
            Assert.AreEqual(expected, myList.ToString());
        }

        [TestMethod]
        public void Convert_StringList_ToString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected = "Hello World";

            //Act
            myList.Add("Hello");
            myList.Add(" ");
            myList.Add("World");

            //Assert
            Assert.AreEqual(expected, myList.ToString());
        }
        
        [TestMethod]
        public void Convert_EmptyList_ToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            string expected = "";
            //Act

            //Assert
            Assert.AreEqual(expected, myList.ToString());
        }
    }
}
