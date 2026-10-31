using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int useNum = -1;
        while (useNum != 0)
        {
            Console.Write("Enter a number or enter '0' to quit: ");
        
            string useResponse = Console.ReadLine();
            useNum = int.Parse(useResponse);

            if (useNum != 0)
            {
                numbers.Add(useNum);
            }
        }
        // Compute total
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The total is: {total}");
        
        // Compute Average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // Find Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Largest number is: {max}");

    }
}