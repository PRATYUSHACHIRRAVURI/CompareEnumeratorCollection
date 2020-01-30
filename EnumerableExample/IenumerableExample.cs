using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableExample
{
        class Employ
        {
            public int Sal { get; set; }

            public static void Main(string[] args)
            {
                Employ e1 = new Employ { Sal = 800 };
                Employ e2 = new Employ { Sal = 700 };
                Employ e3 = new Employ { Sal = 500 };
                Employ e4 = new Employ { Sal = 300 };
                Employ e5 = new Employ { Sal = 700 };
                

                List<Employ> employ = new List<Employ>() { e1, e2, e3, e4, e5};


                IEnumerable<Employ> i = (IEnumerable<Employ>)employ;
                Console.WriteLine("enumerable");
                foreach (Employ e in i)
                {
                    Console.WriteLine(e.Sal);
                }
                Console.ReadKey();

            }
        }

    }

