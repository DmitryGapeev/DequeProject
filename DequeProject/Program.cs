using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      string string1 = "hello world";
      string string2 = "спел лепс";

      Console.WriteLine(string1 + " is palindrom = " + IsPalindrome(string1));
      Console.WriteLine(string2 + " is palindrom = " + IsPalindrome(string2));

      Console.ReadKey();
    }

    static bool IsPalindrome(string str)
    {
      Deque<char> deque = new Deque<char>();
      bool isPalindrome = true;

      foreach (var symblol in str)
        deque.AddFront(symblol);

      foreach (var symblol in str)
        deque.AddFront(symblol);

      while (deque.Size() != 0 && isPalindrome)
      {
        char symblolFromFront = deque.RemoveFront();
        char symblolFromTail = deque.RemoveTail();

        isPalindrome = symblolFromFront == symblolFromTail;
      }

      return isPalindrome;
    }
  }
}
