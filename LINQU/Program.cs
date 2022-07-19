using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQU
{
    class Program
    {

        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Fees { get; set; }
        }



        static void Main(string[] args)
        {

            List<Course> coures = new List<Course>() {
                new Course{Id=101,Name="C#",Fees=2000 },
                  new Course{Id=102,Name="MVC", Fees=4000 },
                  new Course{Id=103,Name="SQL",Fees=6000 },
                  new Course{Id=104,Name="Core Java",Fees=8000 },
                  new Course{Id=105,Name="Ad Java",Fees=10000 },
            };

          
            
            var result1=from c in coures
                      select c;

           



            var result3 = from co in coures
                          where co.Fees < 8000
                          orderby co.Name descending
                          select co;

            var result4 = from c in coures
                          where c.Name.StartsWith('C')
                          select c;




            foreach (Course c in result1)  //change result to result3 result4
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }


        }
    }
}
