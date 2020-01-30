using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExample
{
        class Program
        {
            static void Main(string[] args)
            {
                List<string> Name = new List<string>();
            Name.Add("Jack");
            Name.Add("Jill");
            Name.Add("Rose");
            Name.Add("Kevin");
            Name.Add("Mark");
            Name.Add("Park");
            Name.Add("Martin");
            Name.Add("Mill");
            Name.Add("Stefen");
            Name.Add("Paul");
            Name.Add("Elena");
            Name.Add("Catherine");
                IEnumerator<string> iEnumeratorOfString = Name.GetEnumerator();
                iEnumeratorMethodOne(iEnumeratorOfString);
                Console.ReadKey();
            }
            static void iEnumeratorMethodOne(IEnumerator<string> i)
            {
                while (i.MoveNext())
                {
                    Console.WriteLine(i.Current);

                    if (i.Current == "Mark")
                    {
                        iEnumeratorMethodTwo(i);
                    }
                }
            }

            static void iEnumeratorMethodTwo(IEnumerator<string> i)
            {
                Console.WriteLine("after Mark");
                while (i.MoveNext())
                {
                    Console.WriteLine(i.Current);
                }
            }
        }
    }


