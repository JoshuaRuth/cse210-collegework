using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradeAn = Console.ReadLine();
        int percent = int.Parse(gradeAn);

        string gradeLetter ="";

        if (percent >= 90)
        {
            gradeLetter = "A";
        }
        else if (percent >= 80)
        {
            gradeLetter = "B";
        }
        else if (percent >= 70)
        {
            gradeLetter = "C";
        }
        else if (percent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
    
        Console.WriteLine($"You scored {percent}%! You got a {gradeLetter}!");
    }
}