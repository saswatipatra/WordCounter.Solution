using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordCounter;
using System.Collections.Generic;
using System;


namespace wordCounter.Test{
    [TestClass]
   public class TestingWordCount
   {
       [TestMethod]
       public void WordCounter_Count_1()
       {
           Item newItem = new Item();
           int actualValue = newItem.WordCounterFunction("cat","I am walking with my cat" );
           Assert.AreEqual(1, actualValue);
       }

       [TestMethod]
       public void WordCounter_Count1_onlyTheWord()
       {
           Item newItem = new Item();
           int actualValue = newItem.WordCounterFunction("cat","I am walking with my cat in the cather" );
           Assert.AreEqual(1, actualValue);
       }

       [TestMethod]
       public void WordCounter_Count_mulitpleTime()
       {
           Item newItem = new Item();
           int actualValue = newItem.WordCounterFunction("cat","I am walking with my cat in the cather and cat is running" );
           Assert.AreEqual(2, actualValue);
       }

       [TestMethod]
       public void WordCounter_Count_CaseInsenstivity()
       {
           Item newItem = new Item();
           int actualValue = newItem.WordCounterFunction("cat","I am walking with my cat in the cather and cAt is running. CAT name is CaT" );
           Assert.AreEqual(4, actualValue);
       }

   }
}
