using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordCounter;
using System;

namespace wordCounter.Test{
    [TestClass]
   public class TestingWordCount
   {
      [TestMethod]
       public void Word_Are_Valid_forEmpty_true()
       {
           RepeatCounter newRepeatCounter = new RepeatCounter();
           bool actualValue = newRepeatCounter.IsNull_Empty_true("");
           Assert.AreEqual(true, actualValue);
       }

       [TestMethod]
        public void Word_Are_Valid_forNonEmpty_false()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            bool actualValue = newRepeatCounter.IsNull_Empty_true("cat");
            Assert.AreEqual(false, actualValue);
        }

       [TestMethod]
       public void WordCounter_Count_1()
       {
           RepeatCounter newRepeatCounter = new RepeatCounter();
           int actualValue = newRepeatCounter.WordCounterFunction("cat","I am walking with my cat" );
           Assert.AreEqual(1, actualValue);
       }

       [TestMethod]
       public void WordCounter_Count1_onlyTheWord()
       {
           RepeatCounter newRepeatCounter = new RepeatCounter();
           int actualValue = newRepeatCounter.WordCounterFunction("cat","I am walking with my cat in the cather" );
           Assert.AreEqual(1, actualValue);
       }

       [TestMethod]
       public void WordCounter_Count_mulitpleTime()
       {
           RepeatCounter newRepeatCounter = new RepeatCounter();
           int actualValue = newRepeatCounter.WordCounterFunction("cat","I am walking with my cat in the cather and cat is running" );
           Assert.AreEqual(2, actualValue);
       }

       [TestMethod]
       public void WordCounter_Count_CaseInsenstivity()
       {
           RepeatCounter newRepeatCounter = new RepeatCounter();
           int actualValue = newRepeatCounter.WordCounterFunction("cat","I am walking with my cat in the cather and cAt is running. CAT name is CaT" );
           Assert.AreEqual(4, actualValue);
       }

   }
}
