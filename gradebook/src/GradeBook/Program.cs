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
            book.AddGrades(2.4);
            book.AddGrades(4.5);
            book.AddGrades(100);
            book.AddGrades(48.9);
            book.AddGrades(55.4);
            book.AddGrades(33);
            System.Console.WriteLine("After Grades");
            book.RemoveGrades(3);
           /*  book.RemoveGrades(); */
            book.showStats();
                         
            }

           
    }
}
