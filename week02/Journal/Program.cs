using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {   
        Journal theJournal = new Journal();

        // creates an instance
        PromptGenerator newPrompt = new PromptGenerator();
        
        // Gets a random prompt using PromptGenerator class
        // 'e' comes from creating a an instance of the entry class. 
        Entry._promptText = newPrompt.GetRandomPrompt();
        
        
        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}