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
			TestDeque();

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

      foreach (char symblol in str)
        deque.AddFront(symblol);

      foreach (char symblol in str)
        deque.AddFront(symblol);

      while (deque.Size() != 0 && isPalindrome)
      {
        char symblolFromFront = deque.RemoveFront();
        char symblolFromTail = deque.RemoveTail();

        isPalindrome = symblolFromFront == symblolFromTail;
      }

      return isPalindrome;
    }


	  static void TestDeque()
	  {
		  Console.WriteLine("test deque");
		  Deque<int> deque = new Deque<int>();

		  int i = 1;

		  Console.WriteLine("add in front");
		  for (; i <= 10; i++)
		  {
			  deque.AddFront(i);
			  Console.Write(i + " ");
		  }

		  Console.WriteLine();
		  Console.WriteLine("size after add in front = " + deque.Size());
		  Console.WriteLine();

		  for (; i <= 20; i++)
		  {
			  deque.AddTail(i);
			  Console.Write(i + " ");
		  }

		  Console.WriteLine();
		  Console.WriteLine("size after add in tail = " + deque.Size());
		  Console.WriteLine();

			Console.WriteLine("remove from front");
		  for (int j = 0; j < 5; j++)
			  Console.Write(deque.RemoveFront()+" ");

		  Console.WriteLine();
		  Console.WriteLine("size after remove from front = " + deque.Size());
		  Console.WriteLine();

		  Console.WriteLine("remove from tail");
		  for (int j = 0; j < 5; j++)
			  Console.Write(deque.RemoveTail() + " ");

		  Console.WriteLine();
		  Console.WriteLine("size after remove from tail = " + deque.Size());
		  Console.WriteLine();

			Console.WriteLine("remote from front");
		  while (deque.Size() != 0)
			  Console.Write(deque.RemoveFront() + " ");

		  Console.WriteLine();
		  Console.WriteLine("size after remove from tail = " + deque.Size());
		  Console.WriteLine();

			Console.WriteLine("try to remove from tail, deque size = " + deque.Size());
		  int result = deque.RemoveTail();
			Console.WriteLine("result = " + result);

		  Console.WriteLine("try to remove from front, deque size = " + deque.Size());
		  result = deque.RemoveFront();
		  Console.WriteLine("result = " + result);

			Console.WriteLine(new string('=', 50));
	  }
  }
}
