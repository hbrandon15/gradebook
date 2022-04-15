using System.Collections.Generic;
namespace GradeBook
{


  class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name; 
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);

    }

private List<double> grades;

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

    private string name;

  }

}