using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }

        private static char[] _punctuationMarks = { '.', ',', '!', '?', '*', '(',')', '[', ']', ':', ';', '/' };

        public RepeatCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }

        public static bool ValidInput(string input)
        {
            bool output = true;

            if (input.Contains(' '))    // Invalid input if spaces are present
            {
                output = false;
            }
            else
            {
                for (int i = 0; i < _punctuationMarks.Length; i++)  // Invalid input if punctuation marks are present
                {
                    if (input.Contains(_punctuationMarks[i]))
                    {
                        output = false;
                    }
                }
            }
            return output;
        }

        public int Count()
        {
            int wordCount = 0;

            string[] wordArray = Sentence.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                // Drop punctuation marks from words in the sentence before comparing to the user-given word
                foreach (char punctMark in _punctuationMarks)
                {
                    if (wordArray[i].Contains(punctMark))
                    {
                        wordArray[i] = wordArray[i].Trim(_punctuationMarks);
                    }
                }
                
                if (Word == wordArray[i])
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}