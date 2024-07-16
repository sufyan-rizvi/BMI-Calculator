using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BMI_Calculator.Models;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(101, "Shawn", 35, 1.8, 88) ;
            Console.WriteLine(person1);
        }
    }
}
