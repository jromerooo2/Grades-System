using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Book
    {

        //Add Grades.  

        public void AddGrades(double added)
        {
                 grades.Add(added);   
                Console.WriteLine(added);  
          
        }
        //Remove Grades Method
                public void RemoveGrades(int removed)
        {
              grades.RemoveAt(removed);
                foreach (var num in grades)
                {
                    Console.WriteLine(num + " ");
                }
                             

        }
         
                
        //Shows statistics for the Highest, Lowest n Average Grades
        public void showStats()
        {
            double high = double.MinValue;
            double low = double.MaxValue;
            double avg = 0.0;

            foreach (var number in grades)
            {
                high = Math.Max(number,high);
                low = Math.Min(number,low);
                avg += number;
            }
                avg /= grades.Count;

                Console.WriteLine($"The Highest Grade is {high}");
                Console.WriteLine($"The Lowest Grade is {low}");
                Console.WriteLine($"The Average Grade is {avg}");
        }



        public  Book(string name)
        {

                
        }

        List<double> grades;
              

        }
}