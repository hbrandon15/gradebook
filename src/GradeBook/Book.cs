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
    // This is a simple method that will add a grade to our 'grades' variable
    public void AddGrade(double grade)
    {
      grades.Add(grade);

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
      foreach (var grade in grades)
      {
        result.Low = Math.Min(grade, result.Low);
        result.High = Math.Max(grade, result.High);
        result.Average += grade;
      }
      result.Average /= grades.Count;

      return result;
    }

    // variable declarations
    private List<double> grades;
    public string Name;


  }

}