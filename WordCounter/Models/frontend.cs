using System;
using System.Collections.Generic;
using wordCounter;


namespace wordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter a number");
            int anything = int.Parse(Console.ReadLine());
            Item newItem = new Item();
            string print= newItem.conversion(anything);
            Console.WriteLine(print);
        }
    }
}
