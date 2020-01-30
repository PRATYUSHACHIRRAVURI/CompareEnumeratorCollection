using System;

namespace EquatableExample
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    namespace EquatableExample
    {
        class Student1 : IEquatable<Student1>
        {
            public int Rollnumber { 
                get;
                set; 
            }
            public String Name { 
                get; 
                set; 
            }
            static void Main(string[] args)
            {
                Student1 obj1 = new Student1();
                obj1.Rollnumber = 50;
                obj1.Name = "aparna";
                Student1 obj2 = new Student1();
                obj2.Rollnumber = 50;
                obj2.Name = "amulya";
                Console.WriteLine(obj1.Equals(obj2));
            }
            public bool Equals(Student1 other)
            {
                if (other == null) return false;
                return (this.Rollnumber.Equals(other.Rollnumber));
                
            }
        }
    }
}
