using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifiers
{
    internal class Group
    {
        public string[]No;
        public int StudentLimit;
       

        public Student[]Students=new Student[0];
        public void AddStudent(Student student)
        {
            int StudentLimit = new();
               
                    if (Students.Length < StudentLimit)
                    {
                        Array.Resize(ref Students, Students.Length + 1);
                        Students[Students.Length - 1] = student;
                    }
                    else
                    {
                        Console.WriteLine("Student limit reached.");
                    }

        }
        
        public void ShowStudentInfo()
        {
            if (Students.Length == 0)
            {
                Console.WriteLine("Hec bir telebe tapilmadi.");
                return;
            }
            Console.WriteLine("Butun telebeler:");
            foreach (var student in Students)
            {
                Console.WriteLine($"{student.FullData()}");
            }
        }
         
        public void  SearchByFullName()
        {
         Console.Write("Herf daxil edin:");
            char  ch = char.Parse(Console.ReadLine());
            foreach (var student in Students)
            {
                Console.WriteLine($"{student.FullData()}");
            }
            
        }
    }
}
