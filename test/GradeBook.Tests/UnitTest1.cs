using Xunit;

namespace GradeBook.Tests;

public class UnitTest1
{
    [Fact]
    // Here we are running a simple test to see if our expected 
    // value equals our actual value
    public void Test1()
    {

      // arrange section 
      // this is where you put all your test data and arrange
      // object and values
      var x = 5;
      var y = 2; 
      var expected = 7;

      // act section
      // this is where you invoke a method to perform a computation
      var actual = x + y;

      // assert section
      // this is where you assert something of the value 
      // that is calculated in the act section
      Assert.Equal(expected,actual);

    }
}