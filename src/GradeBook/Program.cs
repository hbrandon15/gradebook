using System;
using System.Collections.Generic;

namespace GradeBook
{

  internal class Program
  {
    static void Main(string[] args)
    {

      var book = new Book("Brandon's gradebook");


      while(true)
      {
      // begin loop
     
        System.Console.WriteLine("Please enter a grade or 'q' to quit");
        
        var input = Console.ReadLine();
        if(input == "q")
        {
          break;
        }
        var grade = double.Parse(input);
        book.AddGrade(grade);

      }
  




      var stats = book.GetStatistics();
      System.Console.WriteLine($"The lowest grade is: {stats.Low}");
      System.Console.WriteLine($"The highest grade is: {stats.High}");
      System.Console.WriteLine($"The average is: {stats.Average:N1}");
      System.Console.WriteLine($"The letter grade is: {stats.Letter}");


    }
  }
}