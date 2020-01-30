using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollectionExample
{
    class Class2
    {
        static void Main(string[] args)
        {
            Custom_Linked_List_Class x = new Custom_Linked_List_Class();
            x.Add(1);
            x.Add(56);
            x.Add(4);
            x.Add(8);
            x.Add(5);
            x.Add(6);
            x.Add(20);
            x.Add(13);
            x.Add(32);
            x.Print();
            Console.WriteLine();
            x.Delete(13);
            Console.WriteLine("After deleting");
            x.Print();
            Console.WriteLine( "Number of elements:"+x.Number_of_Elements());
            Console.WriteLine("Search for element 1 the index is:"+x.Search(x.head,1));
            x.Sort(x.head);
            x.Print();
            Console.WriteLine("Search for element with index 3:" + x.Search_Nth_Index(3));
        }
    }
}
