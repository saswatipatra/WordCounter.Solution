using System;
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
              Console.WriteLine("found the word, number of time it occur: " + count);
              Console.WriteLine("Would you like to search again(yes/no) ");
              string userWish = Console.ReadLine();
              if(userWish=="yes"||userWish=="Yes")
              {
                Main();
              }
              else
              {
                Console.WriteLine("We were glad to have you, you are welcome again, have a good day...");
              }
            }
        }
    }
}
