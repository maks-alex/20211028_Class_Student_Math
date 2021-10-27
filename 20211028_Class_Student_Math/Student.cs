using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211028_Class_Student_Math
{
    class Student
    {
        private string _firstName;
        private string _secondName;
        private string _middleName;
        int _age;
        int[][] _marks;

        public Student()
        {
        }

        public Student(string firstName, string secondName, string middleName, int age)
        {
            _firstName = firstName;
            _secondName = secondName;
            _middleName = middleName;
            _age = age;
            _marks = new int[3][];
            for (int i = 0; i < _marks.Length; i++)
            {
                _marks[i] = new int[20];
            }
        }
        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public string GetFirstName()
        {
            return _firstName;
        }
        public void SetSecondName(string secondName)
        {
            _secondName = secondName;
        }

        public string GetSecondName()
        {
            return _secondName;
        }

        public void SetFatherName(string middleName)
        {
            _middleName = middleName;
        }

        public string GetFatherName()
        {
            return _middleName;
        }

        public void SetAge()
        {
            _age = _age;
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetMark(int subject, int pos, int mark)
        {
            _marks[subject][pos] = mark;
            //for (int i = 0; i < _marks.Length; i++)
            //{
            //    if (i == subject)
            //    {
            //        for (int j = 0; j < _marks[i].Length; j++)
            //        {
            //            if (j == pos)
            //            {
            //                _marks[i][j] = mark;
            //            }
            //        }
            //    }
            //}

        }

        public int GetMark(int subject, int pos)
        {
            //for (int i = 0; i < _marks.Length; i++)
            //{
            //    if (i == subject)
            //    {
            //        for (int j = 0; j < length; j++)
            //        {

            //        }
            //    }
            //}
            return _marks[subject][pos];
        }

        public double GetAverageMark(int subject)
        {
            double sum = 0;
            int counter = 0;
            for (int i = 0; i < _marks[subject].Length; i++)
            {
                if (_marks[subject][i] > 0)
                {
                    sum += _marks[subject][i];
                    counter++;
                }
            }
            if (counter > 0)
            {
                return sum/counter;
            }
            else
            {
                return 0;
            }

        }


        public void PrintStudentData()
        {
            Console.WriteLine($"{_secondName} {_firstName} {_middleName} {_age} years");
        }



        /*
        public void PrintStudentMarks()
        {
            for (int i = 0; i < _marks.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            Console.WriteLine("Programming:");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Admnistration:");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Disign:");
                            break;
                        }
                }
                for (int j = 0; j < _marks[i].Length; j++)
                {
                    Console.Write($"{_marks[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        */


    }
}
