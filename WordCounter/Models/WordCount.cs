using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class WordCount
    {
        private string _keyWordString;
        private string _compareWordString;
        //private string[] compareWordArray;
        //private int _keyCount = 0;

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




        //############ set sentence


        public void SetSentenceString(string newSentenceString)
        {
           _compareWordString = newSentenceString;
        }

        public string GetSentenceString()
        {
            return _compareWordString;
        }

        public string StringSentenceToLower(string wordString)
        {
            string wordLower = _compareWordString.ToLower();
            return wordLower;
        }



        //string s = "there is a cat";
        // Split string on spaces.
        // ... This will separate all the words.
        //string[] words = s.Split(' ');
        //foreach (string word in words)
        //{
        //    Console.WriteLine(word);
        //}



    }
}
