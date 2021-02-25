using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word:");
      string userEnteredWord = (Console.ReadLine()).ToUpper();
      Game newGame = new Game();
      char[] charArray = newGame.SplitStringIntoChar(userEnteredWord);

      int scoredPoint = 0;
      for (int i = 0; i < charArray.Length; i++)
      {
            // Console.WriteLine(charArray[i]);
            scoredPoint += newGame.ReturnCharValue(charArray[i]);
      }
      Console.WriteLine("For the entered word of " + userEnteredWord + " your score was " + scoredPoint);
      Main();
    }
  }
}