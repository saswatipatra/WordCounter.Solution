using System;
using System.Collections.Generic;
using wordCounter;


namespace wordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter the sentance: ");
            string sentance = Console.ReadLine();
            Console.WriteLine("enter the word you are looking for: ");
            string word = Console.ReadLine();
            Item newItem = new Item();
            int count = newItem.WordCounterFunction(word,sentance);
            Console.WriteLine(count);
        }
    }
}
