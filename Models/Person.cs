using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public double Height { get; set; }
        public double Weight { get; set; }


        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = 5;
            Weight = 50;
          
            
        }

        public Person(int id, string name, int age, double height, double weight) : this(id, name, age)
        {
            Height = height;
            Weight = weight;    
        }

        public double CalculateBMI()
        {
            return (Math.Round(Weight / (Height * Height), 1));
            
        }

        public string BodyType(double bmiScore)
        {
            if (bmiScore < 16)
                return $"{Name} has severe thinness";
            else if (bmiScore > 16 && bmiScore < 17)
                return $"{Name} has moderate thinness";
            else if (bmiScore > 17 && bmiScore < 18.5)
                return $"{Name} has mild thinness";
            else if (bmiScore > 18.5 && bmiScore < 25)
                return $"{Name} is normal";
            else if (bmiScore > 25 && bmiScore < 30)
                return $"{Name} is overweight";
            else if (bmiScore > 30 && bmiScore < 35)
                return $"{Name} has Obese Class I";
            else if (bmiScore > 35 && bmiScore < 40)
                return $"{Name} has Obese Class II";
            else
                return $"{Name} has Obese Class III";
        }

        public override string ToString()
        {
            double bmiScore = CalculateBMI();
            return $"Name: {Name}\n" +
                $"Id: {Id}\n" +
                $"Age: {Age}\n" +
                $"Height: {Height}\n" +
                $"Weight: {Weight}\n" +
                $"BMI Score: {bmiScore}\n" +
                $"Body Type: {BodyType(bmiScore)}\n";
        }
    }
}
