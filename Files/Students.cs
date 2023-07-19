using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    internal class Students
    {
        public void readData()
        {
            string readText = File.ReadAllText("D:\\c#\\Files\\data.txt");
            Console.WriteLine(readText);
            
        }
        public void writeData(int aid ,string aname ,int alevel , double agpa,string agrade)
        {
            string name = aname , grade = agrade;
            double gpa = agpa;
            int level=alevel,id=aid;
            string writeText = ("\n"+id+"\t"+name+"\t"+level+"\t"+gpa+"\t"+grade);
            File.AppendAllText("D:\\c#\\Files\\data.txt", writeText);
        }
    }
}
