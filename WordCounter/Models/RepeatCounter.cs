using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }
        
        private char[] _punctuationMarks = { '.', ',', '!', '?', '*', '(',')', '[', ']', ':', ';', '/' };

        public RepeatCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }

        public bool ValidInput()
        {
            bool output = true;

            if (Word.Contains(' '))
            {
                output = false;
            }
            else
            {
                for (int i = 0; i < _punctuationMarks.Length; i++)
                {
                    if (Word.Contains(_punctuationMarks[i]))
                    {
                        output = false;
                    }
                }
            }

            return output;
        }

        public int Count()
        {
            int finalCount = 0;

            string[] wordArray = Sentence.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                foreach (char punctMark in _punctuationMarks)
                {
                    if (wordArray[i].Contains(punctMark))
                    {
                        wordArray[i] = wordArray[i].Trim(_punctuationMarks);
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