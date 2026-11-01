using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello User: ");
        }
    
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("ENTER YOUR NAME: ");
            string name = Console.ReadLine();

            return name;
        }

        string userName = PromptUserName();
        
        static int PromptUserNumber()
        {
            Console.Write("ENTER YOUR FAVORITE NUMBER: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        int userNumber = PromptUserNumber();

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        
        int SquaredNumber = SquareNumber(userNumber);

        static void DisplayResult(string name, int number, int square)
        {
            Console.WriteLine($"{name}, the number you entered is {number}, the square of your number is {square}");
        }

        DisplayResult(userName,userNumber,SquaredNumber);
    
    
    }
}