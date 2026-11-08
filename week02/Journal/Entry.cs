public class Entry
{   
    /*
    // 
    date: Date from computer? 
    promptText: selects a random prompt that asks the user what they want (done in Program.cs)
    entryText: Entry text that the user inputs. (do that part in main program.) 
    */
    public string _date = "XX/XX/XXXX";
    public string _promptText = "";
    public string _entryText = "";
    
    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
    }
    //

}
