using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }

        public RepeatCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }

        public int Count()
        {
            int finalCount = 0;

            string[] wordArray = Sentence.Split(' ');
            foreach (string wordOfSentence in wordArray)
            {
                if (Word == wordOfSentence)
                {
                    finalCount++;
                }
            }

            return finalCount;
        }
    }
}