using System;

namespace GradeBook
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var numbers = new double[3]; 
      numbers[0] = 12.7; 
      numbers[1] = 13.5;
      numbers[2] = 20.1;

      var sum = numbers[0] + numbers[1] + numbers[2];
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