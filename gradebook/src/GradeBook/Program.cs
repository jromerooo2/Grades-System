using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
         static void Main(string[] args)
            {  

                            //Main class
            var book = new Book("Math Book");
             System.Console.WriteLine("Before Grades:");
            book.AddGrades();
            book.AddGrades();
            book.AddGrades();
            book.AddGrades();
            book.AddGrades();
            book.AddGrades();
            System.Console.WriteLine();
            book.RemoveGrades();
           /*  book.RemoveGrades(); */
            book.showStats();
                         
            }

           
    }
}
