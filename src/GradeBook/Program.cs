using System;

namespace GradeBook // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
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