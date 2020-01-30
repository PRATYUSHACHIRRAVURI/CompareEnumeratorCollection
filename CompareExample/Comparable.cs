using System;
using System.Collections.Generic;

namespace CompareExample
{
    class Student : IComparable
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
        public int CompareTo(object obj)
        {
            if (!(obj is Student))
            {
                throw new ArgumentException("Compared Object is not of Student");
            }
            return Name.CompareTo(this.Name);
        }
        static void Main(string[] args)
        {
            Student[] student = new Student[]
    {
        new Student()
        {
            Name = "Pratyusha"
        }, new Student()
        {
            Name = "Amulya"
        }, new Student()
        {
            Name = "Carol"
        }
    };
            Array.Sort(student);
            Array.ForEach(student, x => Console.WriteLine(x.Name));
        }

    }
}
