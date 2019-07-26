using System;
using WordCounter.Models;

class Program
{
    private static string GetWord()
    {
        Console.Write("\nPlease enter a word: ");
        string userWord = Console.ReadLine();
        bool validInput = RepeatCounter.ValidInput(userWord);

        if (!validInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input: The word cannot have spaces or punctuation.");
            Console.ResetColor();

            GetWord();
        }

        return userWord;
    }

    private static string GetSentence()
    {
        Console.Write("\nPlease enter a sentence: ");
        string userSentence = Console.ReadLine();
        
        if (userSentence.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input: Sentence cannot be empty.");
            Console.ResetColor();

            GetSentence();
        }

        return userSentence;
    }
    
    private static void Main()
    {
        Console.Clear();
        Console.WriteLine("------1---------5------------4---");
        Console.WriteLine("-          WORD COUNTER         -");
        Console.WriteLine("---3--6-------------------2------");
        Console.WriteLine("\nFind out how many times a word appears in a sentence!");

        GetWord();
        GetSentence();

    }
}
