using System.Collections.Generic;
namespace GradeBook
{
  public delegate void GradeAddedDelegate(object sender, EventArgs args);


  public class InMemoryBook : Book
  {
    // This is our basic constructor method that sets every Book object
    // with a variable named 'grades' 
    public InMemoryBook(string name) : base(name)
    {
      const int X = 3; 
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
    public override void AddGrade(double grade)
    {
      if (grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
        if(GradeAdded != null)
        {
          GradeAdded(this,new EventArgs());
        }
      }

      else
      {
        throw new ArgumentException($"Invalid {nameof(grade)}");
      }

    }

    public event GradeAddedDelegate GradeAdded;
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

      switch (result.Average)
      {
        case var d when d >= 90.0:
          result.Letter = 'A';
          break;

        case var d when d >= 80.0:
          result.Letter = 'B';
          break;

        case var d when d >= 70.0:
          result.Letter = 'C';
          break;

        case var d when d >= 60.0:
          result.Letter = 'D';
          break;

        default:
          result.Letter = 'F';
          break;
      }

      return result;
    }

    // variable declarations
    private List<double> grades;

    public const string CATEGORY  = "Science"; 



  }

}