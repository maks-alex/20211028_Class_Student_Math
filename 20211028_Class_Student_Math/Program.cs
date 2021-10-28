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
            /*
             1. Придумать класс, описывающий студента и предусмотреть в
нем следующие поля: имя, фамилия, отчество, группа,
возраст, массив (рваный) оценок по программированию,
администрированию и дизайну. Также добавить методы по
работе с перечисленными данными: возможность установки/
получения оценки, получение среднего балла по данному
предмету, распечатка данных о студенте.
             */

            Random rand = new Random();
            Student student = new Student("Oleksandr","Maksymikhin","Vladyslavovych", 40);
            student.PrintStudentData();

            Console.WriteLine("\nSet random marks");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < rand.Next(5,20); j++)
                {
                    student.SetMark(i, j, rand.Next(1, 12));
                }
            }

            Console.WriteLine("\nMarks for subjects:");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.Write("Programming".PadRight(15, '_'));
                }
                else if (i == 1)
                {
                    Console.Write("Adminstration".PadRight(15, '_'));
                }
                else if (i == 2)
                {
                    Console.Write("Design".PadRight(15, '_'));
                }
                for (int j = 0; j < 20; j++)
                {

                    Console.Write(student.GetMark(i, j).ToString().PadLeft(2) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            double averageMark = student.GetAverageMark(0);
            Console.Write("Average mark for Programming".PadRight(35,'_'));
            Console.WriteLine(String.Format("{0:F1}", student.GetAverageMark(0)).PadLeft(2, '_'));

            Console.Write("Average mark for Adminstration".PadRight(35, '_'));
            Console.WriteLine(String.Format("{0:F1}", student.GetAverageMark(1)).PadLeft(2, '_'));

            Console.Write("Average mark for Design".PadRight(35, '_'));
            Console.WriteLine(String.Format("{0:F1}", student.GetAverageMark(2)).PadLeft(2, '_'));

            Console.WriteLine();


            /*
             2. Написать статический класс, который предоставляет статические методы для:
- расчета экспоненциальной функции;
- нахождения арксинуса заданного аргумента;
- нахождения расстояния между двумя точками в трехмерном пространстве;
- транспонирования матрицы.
             */
        }

    }
}
