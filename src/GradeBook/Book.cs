using System.Collections.Generic;
namespace GradeBook
{


  class Book
  {
    // This is our basic constructor method that sets every Book object
    // with a variable named 'grades' 
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    // This is a simple method that will add a grade to our 'grades' variable
    public void AddGrade(double grade)
    {
      grades.Add(grade);

    }
    // this method will parse through the 'grades' list and determine
    // the sum, lowGrade, highGrade, and average. Then it will print 
    // the results to the console
    public void ShowStatistics()
    {
      var sum = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      foreach (var number in grades)
      {
        lowGrade = Math.Min(number, lowGrade);
        highGrade = Math.Max(number, highGrade);
        sum += number;
      }
      var avg = sum / grades.Count;


      System.Console.WriteLine($"The lowest grade is: {lowGrade}");
      System.Console.WriteLine($"The highest grade is: {highGrade}");
      System.Console.WriteLine($"The average is: {avg:N1}");

    }

    // variable declarations
    private string name;
    private List<double> grades;

  }

}