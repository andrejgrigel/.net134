using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class Student
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
        }

        private string _group;
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int[][] _marks;

        public Student(string name, string surname, string middlename = "")
        {
            this._name = name;
            this._surname = surname;
            this._middleName = middlename;
            _marks = new int[3][];
            _numberOfMarks = new int[3];
        }

        public enum Courses {Programming, Administrating, Design };

        private int[] _numberOfMarks;
        
        public void SetMarks(Courses course, params int[] marks)
        {
            int subject = (int) course;
            foreach (var mark in marks)
            {
                _numberOfMarks[subject]++;
                _marks[subject][_numberOfMarks[subject]] = mark;
            }
        }

        public int GetMark(Courses course, int lesson)
        {
            int subject = (int) course;
            return _marks[subject][lesson - 1];
        }

        public int [] GetAllMarks(Courses course)
        {
            int subject = (int) course;
            return _marks[subject];
        }

        public int GetSumOfMarks(Courses course)
        {
            int subject = (int) course;
            int sum = 0;
            foreach (int mark in _marks[subject])
            {
                sum += mark;
            }
            return sum;
        }

        public double GetAverageMark(Courses course)
        {
            try
            {
                return (double) GetSumOfMarks(course)/_numberOfMarks[(int) course];
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        public void ShowSummary()
        {
            Console.WriteLine("Student: {0} {1} {2}", Surname, Name, MiddleName);
            Console.WriteLine("Group: {0}, Age: {1}", Group, Age);
            Console.WriteLine("Average mark in {0} is: {1}", Courses.Programming, 
                GetAverageMark(Courses.Programming));
            Console.WriteLine("Average mark in {0} is: {1}", Courses.Administrating,
                GetAverageMark(Courses.Administrating));
            Console.WriteLine("Average mark in {0} is: {1}", Courses.Design,
                GetAverageMark(Courses.Design));
        }
    }
}
