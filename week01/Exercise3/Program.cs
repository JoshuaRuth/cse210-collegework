using System;
using System.ComponentModel;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.write("Insert magic number...");
        // int magicNum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);

        int guessNum = -1;

        while(guessNum != magicNum)
        {
            Console.Write("What number do you think it is? ");
            guessNum = int.Parse(Console.ReadLine());
            
            if (guessNum < magicNum)
            {
                Console.WriteLine("YOU GUESSED TOO LOW!");
            }
            else if (guessNum > magicNum)
            {
                Console.WriteLine("YOU GUESSED TOO HIGH!");
            }
            else
            {
                Console.WriteLine("YOU GUESSED WELL!");
            }
        }
    }



}

