﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

  internal class Program
{
  static void Main(string[] args)
  {

    var book = new Book("Brandon's gradebook"); 
    book.AddGrade(89.1);
    book.AddGrade(90.5);
    book.AddGrade(77.5);
    book.ShowStatistics();
  }
}
}