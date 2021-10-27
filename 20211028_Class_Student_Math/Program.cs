using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211028_Class_Student_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Oleksandr","Maksymikhin","Vladyslavovych", 40);
            student.PrintStudentData();
        }

    }
}
