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

           

            //using linq query

            var result3 = from co in coures
                          where co.Fees < 8000
                          orderby co.Name descending
                          select co;

            var result4 = from c in coures
                          where c.Name.StartsWith('C')
                          select c;

            var result5 = from c in coures
                          where c.Name.Contains('C')
                          select c;


            var result6 = from c in coures
                          where c.Name.EndsWith('C')
                          select c;

           
            //using LABDA expression
            // =>  arrow operator  also called lambda expression
            var result7 = coures.Where(x => x.Fees < 8000).OrderByDescending(y => y.Name).ToList();

            var result8 = coures.Where(x => x.Id == 101).FirstOrDefault();

            var result9 = coures.Where(j => j.Fees > 6000).ToList();

            var result10 = coures.Where(a => a.Fees > 5000).OrderBy(b => b.Name).ToList();


            

            foreach (Course c in result10)  //change result to result3 result4
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }




           Console.WriteLine("//////////////////////////////////////////////////////////////");



            foreach (Course x in result5)  //change result to result3 result4
            {
                Console.WriteLine($"{x.Id}  {x.Name} {x.Fees}");
            }



        }
    }
}
