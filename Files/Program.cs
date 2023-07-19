using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            Console.WriteLine("hi in the manage student system ");
            bool counter = true;
            while (counter) {
                Console.WriteLine("\nwhat you want to do\n" +
                    "\n1-read all studnt data\n2-add student data\n" +
                    "3-exite\n\n" +
                    "press the number of the operation:");
                
                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {

                        student.readData();
                    }
                    else if (option == 2)
                    {
                        var data = getStudentData();

                        Console.WriteLine(data.Item1);
                        student.writeData(data.Item1,data.Item2,data.Item3,data.Item4,data.Item5);
                    }
                    else
                    {
                        counter = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong try again with your option.");
                }
            }
            Console.ReadLine();
        }
        static Tuple<int, string, int,double,string> getStudentData()
        {
            try
            {

                Console.WriteLine("enter student id:");
                int id = Convert.ToInt32(Console.ReadLine());
     
                Console.WriteLine("enter student name:");
                string name = Console.ReadLine();
         
                Console.WriteLine("enter student level:");
                int level = Convert.ToInt32(Console.ReadLine());
             
                Console.WriteLine("enter student gpa:");
                double gpa = Convert.ToDouble(Console.ReadLine());
           
                Console.WriteLine("enter student grade:");
                string grade = Console.ReadLine();
             
                var result = Tuple.Create(id,name,level,gpa,grade);
                return result;
            }
            catch
            {
                Console.WriteLine("error try again");
            }
            return null;
        }
      
    }
}
