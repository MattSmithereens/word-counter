using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models;

namespace WordCounter.Tests.ModelsTest
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void GetWordString_ReturnWordString_String()
        {
            //Arrange
            string testString = "cat";
            WordCounter inputWord = new WordCounter(testString);

            //Act
            string result = inputWord.GetWordString();

            //Assert
            Assert.AreEqual(testString, result);
        }
    }
}
