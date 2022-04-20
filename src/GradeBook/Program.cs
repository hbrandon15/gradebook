﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

  internal class Program
  {
    static void Main(string[] args)
    {

      var book = new Book("Brandon's gradebook");
      book.GradeAdded += OnGradeAdded;
      book.GradeAdded += OnGradeAdded;
      book.GradeAdded -= OnGradeAdded;
      book.GradeAdded += OnGradeAdded;




      while(true)
      {
      // begin loop
     
        System.Console.WriteLine("Please enter a grade or 'q' to quit");
        
        var input = Console.ReadLine();
        if(input == "q")
        {
          break;
        }
        try
        {
        var grade = double.Parse(input);
        book.AddGrade(grade);
        }
        catch(ArgumentException ex)
        {
          System.Console.WriteLine(ex.Message);
        
        }
        catch(FormatException ex)
        {
          System.Console.WriteLine(ex.Message);
        }

        finally
        {
          //..
          System.Console.WriteLine("**");
        }

      }
  




      var stats = book.GetStatistics();
      System.Console.WriteLine($"For the book named {book.Name}");
      System.Console.WriteLine($"The lowest grade is: {stats.Low}");
      System.Console.WriteLine($"The highest grade is: {stats.High}");
      System.Console.WriteLine($"The average is: {stats.Average:N1}");
      System.Console.WriteLine($"The letter grade is: {stats.Letter}");


    }

    static void OnGradeAdded(object sender, EventArgs e)
    {
System.Console.WriteLine("A grade was added");

    }
  }
}