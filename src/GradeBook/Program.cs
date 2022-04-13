using System;

namespace GradeBook
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var numbers = new[] { 12.7, 13.5, 20.1 };

      var sum = 0.0;
      foreach (double number in numbers)
      {
        sum += number;
      }
      System.Console.WriteLine(sum);

      if (args.Length > 0)
      {
        Console.WriteLine($"Hello, {args[0]}!");

      }
      else
      {
        Console.WriteLine("Hello");
      }

    }
  }
}