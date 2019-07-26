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
            if (Word == Sentence)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}