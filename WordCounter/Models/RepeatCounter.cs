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
            char[] punctuationMarks = { '.', ',', '!', '?', '*', '(', ')', '[', ']', ':', ';', '/' };

            string[] wordArray = Sentence.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                foreach (char punctMark in punctuationMarks)
                {
                    if (wordArray[i].Contains(punctMark))
                    {
                        wordArray[i] = wordArray[i].Trim(punctuationMarks);
                    }
                }
                
                if (Word == wordArray[i])
                {
                    finalCount++;
                }
            }

            return finalCount;
        }
    }
}