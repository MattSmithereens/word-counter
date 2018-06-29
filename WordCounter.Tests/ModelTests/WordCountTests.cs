using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models;
using WordCounter;

namespace WordCounter.Tests.ModelTests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void GetWordString_ReturnWordString_String()
        {
            //Arrange
            string testString = "bang";
            WordCount inputWord = new WordCount(testString);

            //Act
            string result = inputWord.GetWordString();

            //Assert
            Assert.AreEqual(testString, result);
        }

        [TestMethod]
        public void StringToLower_ReturnStringLower_String()
        {
            //Arrange
            string testString = "BANG";
            WordCount inputWord = new WordCount(testString);

            //Act
            string lowerTest = "bang";
            string result = inputWord.StringToLower(testString);


            //Assert
            Assert.AreEqual(lowerTest, result);
        }
    }
}
