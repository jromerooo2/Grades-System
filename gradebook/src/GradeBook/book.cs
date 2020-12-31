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

                             

        }
         
                
        //Shows statistics for the Highest, Lowest n Average Grades
        public void showStats()
        {

        }



        public  Book(string name)
        {

                
        }

        List<double> grades;
              

        }
}