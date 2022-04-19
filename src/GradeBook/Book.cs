using System.Collections.Generic;
namespace GradeBook
{


  public class Book
  {
    // This is our basic constructor method that sets every Book object
    // with a variable named 'grades' 
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddLetterGrade(char letter)
    {
      switch (letter)
      {
        case 'A':
          AddGrade(90);
          break;

        case 'B':
          AddGrade(80);
          break;

        case 'C':
          AddGrade(70);
          break;

        case 'D':
          AddGrade(60);
          break;

        default:
          AddGrade(0);
          break;

      }
    }
    // This is a simple method that will add a grade to our 'grades' variable
    public void AddGrade(double grade)
    {
      if (grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
      }

      else
      {
        System.Console.WriteLine("Invalid value");
      }

    }
    // this method will parse through the 'grades' list and determine
    // the sum, lowGrade, highGrade, and average. Then it will print 
    // the results to the console
    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      for (var index = 0; index < grades.Count; index++)
      {
        if (grades[index] == 42.1)
        {
          continue;
        }
        result.Low = Math.Min(grades[index], result.Low);
        result.High = Math.Max(grades[index], result.High);
        result.Average += grades[index];
      }
      result.Average /= grades.Count;

      return result;
    }

    // variable declarations
    private List<double> grades;
    public string Name;


  }

}