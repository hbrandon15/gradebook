using System;
using Xunit;

namespace GradeBook.Tests;

public class TypeTests
{
  [Fact]
  public void Test1()
  {

    // arrange section 
    // this is where you put all your test data and arrange
    // object and values
    var book1 = GetBook("Book 1");
    var book2 = GetBook("Book 2");

    Book GetBook(string name)
    {
      return new Book(name);
    }

    // act section
    // this is where you invoke a method to perform a computation


    // assert section
    // this is where you assert something of the value 
    // that is calculated in the act section
    Assert.Equal("Book 1", book1.Name);
    Assert.Equal("Book 2", book2.Name);


  }


}