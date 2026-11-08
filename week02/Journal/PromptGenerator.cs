using System;
using System.Collections.Generic;  


public class PromptGenerator
{
    // Empty list
    public List<string> _prompts;

    // RNG(randomGen) is placed outside of "GetRandomPrompt" so only 1 generator exists. 
    // 'private' = restricted to this class.
    // 'static' = 1 random object for every instance of promptGenerator.
    private static Random randomGen = new Random();
    
    //
    public PromptGenerator()
    {
        // Strings for list
        _prompts = new List<string>();
        _prompts.Add("How did you feel today?");
        _prompts.Add("Did you see anything interesting?");
        _prompts.Add("How is a friend or loved one doing?");
        _prompts.Add("Did you see anything that annoyed you today?");
        _prompts.Add("Did you experience a tender mercy today?");
    }

    // Adds questions to list. 
    public string GetRandomPrompt()
    {
        int number = randomGen.Next(1,6);
        return _prompts[- 1];
    }

}
/*
random notes:

"How did you feel today?"
"Did you see anything interesting?"
"How is a friend or loved one doing?"
"Did you see anything that annoyed you today?"
"What did you dream of?"

(1,6)

also pressing 'ctrl + / makes a line into a single line comment. 
*/