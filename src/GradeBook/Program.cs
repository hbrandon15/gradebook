using System;
using System.Collections.Generic;

namespace GradeBook
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var grades = new List<double>() { 12.7, 13.5, 20.1 };
      grades.Add(56.1);

      var sum = 0.0;
      foreach (var number in grades)
      {
        sum += number;
      }
      var avg = sum / grades.Count;
      System.Console.WriteLine($"The sum is: {sum:N1}");
      System.Console.WriteLine($"The average is: {avg:N1}");


    }
  }
}