using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class WordCount
    {
        private string _keyWordString;
        private string _compareWordString;
        private int _keyCount = 0;
        public WordCount(string wordString = "")
        {
            _keyWordString = wordString;
        }

        public void SetWordString(string newWordString)
        {
            _keyWordString = newWordString;
        }

        public string GetWordString()
        {
            return _keyWordString;
        }

        public string StringToLower(string wordString)
        {
            string wordLower = _keyWordString.ToLower();
            return wordLower;
        }
    }
}
