using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;




namespace ConsoleApplication1
{
  
 
    class Program
    {
        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public int phone { get; set; }
            public int age { get; set; }



        }
        class Program1
        {

            static void Main(string[] args)
            {

                List<Employee> list = new List<Employee>() {
                   new Employee { id = 9955, name = "shubham" , email = "shubham@email.com", phone = 999711798 , age = 30},

                   new Employee { id = 9956, name = "saurabh" , email = "saurabh@email.com", phone = 888845689 , age = 44},
                   new Employee { id = 9957, name = "mayank " , email = "mayank@email.com ", phone = 756894563 , age = 59},
                   new Employee { id = 9958, name = "aniketr" , email = "aniket@email.com ", phone = 651235489 , age = 12},
                   new Employee { id = 9959, name = "aman   " , email = "aman@email.com   ", phone = 545236958 , age = 33},
                   new Employee { id = 9960, name = "manas  " , email = "manas@email.com  ", phone = 456329871 , age = 15},
                   new Employee { id = 9961, name = "sandeep" , email = "sandeep@email.com", phone = 325698745 , age = 28},
                   new Employee { id = 9962, name = "praveen" , email = "praveen@email.com", phone = 210245698 , age = 36},
                   new Employee { id = 9963, name = "rahul  " , email = "rahul@email.com  ", phone = 123689987 , age = 10},
                   new Employee { id = 9964, name = "rohit  " , email = "rohit@email.com  ", phone = 121365648 , age = 65},


            };
                Console.WriteLine("\n Here Is The Employee Details :\n ");
                string json = JsonConvert.SerializeObject(list.ToArray(), Formatting.Indented);
                Console.WriteLine(json);

                System.IO.File.WriteAllText(@"E:\DayUsers\Shubham\Projects\C#\22_07_2017_test_c#\ConsoleApplication1\ConsoleApplication1\bin\Test-22.json", json);
                /*foreach (var s in list)
                {
                    Console.WriteLine(s.id + " " + s.name + " " + s.phone + " " + s.email + " " + s.age);
                }*/
                Console.WriteLine("\n Assignment_1 Complted");
                Console.ReadKey();
            }
        }



    }
}
