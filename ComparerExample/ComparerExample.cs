using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerExample
{
    class Student
    {
        public string Name
        {
            get;
            set;
        }
        public int RollNumber
        {
            get;
            set;
        }
    }
        class CompareExample : IComparer<Student>
    {
        public enum SortBy
        {
            Name,
            RollNumber
        }
        private SortBy compareField = SortBy.Name;
        public int Compare(Student x, Student y)
        {


            switch (compareField)
            {
                case SortBy.Name:
                    return x.Name.CompareTo(y.Name);

                case SortBy.RollNumber:
                    return x.RollNumber.CompareTo(y.RollNumber);

                default:
                    break;
            }
            return x.Name.CompareTo(y.Name);
        }
        private static void Main(string[] args)
        {
            Student[] stu = new Student[]
            {
        new Student()
        {
            Name = "Pratyusha"
        }, new Student()
        {
            Name = "Carol"
        }, new Student()
        {
            Name = "Amulya"
        }
            };
            var c = new CompareExample();
            c.compareField = CompareExample.SortBy.RollNumber;
            Array.Sort(stu, c);
            Array.ForEach(stu, x => Console.WriteLine(x.Name));
        }
    }
}

    