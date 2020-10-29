using System;
using System.Collections.Generic;
/*
Exercises C# Reverse Strings
program that:
•	Reads an input string
•	Reverses it using a Stack<T>
•	Prints the result back at the terminal
Date: 29/10/2020
*/
namespace StackReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to reverse:");
            String s = Console.ReadLine();

            // Create an empty character array stack
            Stack<String> stack = new Stack<String>();
            // To split input string to tokens (words)
            String[] token = s.Split(' ');

            // Push words into the stack
            for (int i = 0; i < token.Length; i++)
            {
                stack.Push(token[i]);
            }
            Console.WriteLine("Reverse string is:");
            // Pop words from the stack
            while (stack.Count != 0)
            {
                // to print words in reverse order
                String reverse = stack.Pop();
                // With Inbuilt Method Array.Reverse Method  
                char[] charArray = reverse.ToCharArray();
                Array.Reverse(charArray);
                Console.Write(new string(charArray));
                Console.Write(" ");
                
            }
        }
    }
}
