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
            RepeatCounter newRepeatCounter = new RepeatCounter();
            if (newRepeatCounter.IsNull_Empty_true(word))
            {
              Console.WriteLine("enter a valid word");
              Main();
            }
            else
            {
              int count = newRepeatCounter.WordCounterFunction(word,sentance);
              Console.WriteLine(count);
            }
        }

    }
}
