using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_0215
{
    public class Student : Person
    {
        public Student(string name , int age):base(name, age) 
        {
        }
        public string IsCollegeStudent()
        {
            if (IsAdult())
            {
                return "CollegeStudent";
               
            }
            else
            {
                return "GradeStudent";
            }
        }
    }
}
