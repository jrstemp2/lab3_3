using System;
using System.Collections.Generic;

namespace lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            //write method that reverses a string. 

            //user input

            while (true)
            {

                Console.Write("Please Enter A Word or a sentence: ");
                input = Console.ReadLine();
                int num = 0;

                if (int.TryParse(input, out num))
                {
                    Console.WriteLine("That is not a word");
                    continue;
                }
                else
                {
                    break;
                }
            } 

            ReverseWord(input);
            Console.WriteLine();
            
            
            ReverseSentence(input);
            Console.WriteLine();


        }

        static string ReverseWord(string str)
        {
            char[] wordArray = str.ToCharArray();
            Stack<char> reverseStack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                reverseStack.Push(str[i]);
            }
            Console.Write($"The Word {str} spelled backwards is ");
            while (reverseStack.Count > 0)
            {
                Console.Write(reverseStack.Pop());
            }
            return str;
        }

        static string ReverseSentence(string sent)
        {
            string sentence = sent;
            string[] splitSent = sentence.Split(' ');
            Array.Reverse(splitSent);
            
            Console.Write("The Senetence backwars is: ");
            foreach (string word in splitSent)
            {
                System.Console.Write($"{word} ");
            }
            
            return sent;
        }


    }
}
