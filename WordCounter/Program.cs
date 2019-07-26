using System;
using WordCounter.Models;

class Program
{
    private static string _userWord;
    private static string _userSentence;

    private static void GetWord()
    {
        Console.Write("\nPlease enter a word: ");
        string userInput = Console.ReadLine();
        bool validInput = RepeatCounter.ValidInput(userInput);

        if (!validInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input. Please enter a single word with no punctuation marks.");
            Console.ResetColor();

            GetWord();
        }
        else
        {
            _userWord = userInput;
        }
    }

    private static void GetSentence()
    {
        Console.Write("\nPlease enter a sentence: ");
        string userInput = Console.ReadLine();
        
        if (userInput.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a sentence.");
            Console.ResetColor();

            GetSentence();
        }
        else
        {
            _userSentence = userInput;
        }
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

        RepeatCounter newCounter = new RepeatCounter(_userWord, _userSentence);

        int wordCount = newCounter.Count();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nThe word \"{_userWord}\" appears in the sentence {wordCount} time(s).");
        Console.ResetColor();

        Console.Write("\nPress R to replay, E to exit: ");
        string userInput = Console.ReadLine();

        if (userInput == "R" || userInput == "r")
        {
            Main();
        }
        else
        {
            Environment.Exit(0);
        }
    }
}
