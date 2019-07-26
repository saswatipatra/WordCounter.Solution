using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordCounter;
using System.Collections.Generic;
using System;


namespace wordCounter.Test{
    [TestClass]
   public class ClassName
   {
       [TestMethod]

       public void TestFunction1()
       {
           Item newItem = new Item();
           string actualValue = newItem.conversion(9);
           Assert.AreEqual("expectedvalue", actualValue);

       }

   }
}
