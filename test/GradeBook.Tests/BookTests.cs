using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
  [Fact]
  // Here we are running a simple test to see if our expected 
  // value equals our actual value
  public void Test1()
  {

    // arrange section 
    // this is where you put all your test data and arrange
    // object and values
    var book = new Book("");
    book.AddGrade(89.1);
    book.AddGrade(90.5);
    book.AddGrade(77.3);

    // act section
    // this is where you invoke a method to perform a computation
    var result = book.GetStatistics();

    // assert section
    // this is where you assert something of the value 
    // that is calculated in the act section
    Assert.Equal(85.6, result.Average, 1);
    Assert.Equal(90.5, result.High, 1);
    Assert.Equal(77.3, result.Low, 1);

  }
}