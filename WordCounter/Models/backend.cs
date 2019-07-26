using System;
using System.Collections.Generic;

namespace wordCounter
{
public class RepeatCounter
{
  public bool IsNull_Empty_true(String str)
  {
    return (str == null || str == String.Empty) ? true : false;
  }

  public int WordCounterFunction (string word, string sentance)
  {
    int counter=0;
    word= word.ToUpper();
    sentance= sentance.ToUpper();
    string[] wordArry= sentance.Split(' ');
    for (int i=0; i<wordArry.Length; i++)
      {
        if (wordArry[i]==word)
        {
          counter++;
        }
      }
       return counter;
  }
}
}
