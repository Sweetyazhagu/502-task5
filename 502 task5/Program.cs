using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _502_task5
{
    public class student
    {
        public double maths;
        public double physics;
        public double chemistry;
        public double computerscience;
        public double calculateaverage()
        {
            double average = (maths + physics + chemistry + computerscience) / 4.0;
            return average;

        }

    }
    public class genarte
    {
        public static void Main(string[] args)
        {
            student student1 = new student();
            char grade=' ';
            try
            {
                Console.WriteLine("Enter the maths marks: ");
                student1.maths = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the physics marks: ");
                student1.physics = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the chemistry marks: ");
                student1.chemistry = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the computerscience marks: ");
                student1.computerscience = Convert.ToDouble(Console.ReadLine());
                double average = student1.calculateaverage();
                Console.WriteLine("The average of four marks: " + average);


                if (average >= 80)
                {
                    grade = 'A';
                    Console.WriteLine(" Grade : " + grade);
                    return;
                }
                else if (average >= 70 && average < 80)
                {
                    grade = 'B';
                    Console.WriteLine(" Grade : " + grade);
                    return;
                }

                else if (average >= 60 && average < 70)
                {
                    grade = 'C';
                    Console.WriteLine(" Grade : " + grade);
                    return;
                }

                else if (average >= 50 && average < 60)
                {
                    grade = 'D';
                    Console.WriteLine(" Grade : " + grade);
                    return;
                }

                else
                {
                    grade = 'F';
                    Console.WriteLine(" Grade : " + grade);
                    return;
                }




            }
            catch (FormatException)
            {
                Console.WriteLine(" Invalid number ");
            }

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case 'B':
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case 'D':
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case 'F':
                    Console.WriteLine("Fail. Your grade is F");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
            Console.ReadLine();
        }
    }
}