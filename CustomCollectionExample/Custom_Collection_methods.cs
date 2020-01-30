using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionExample
{
        public class Custom_Linked_List_Class
        {
            public node head;
            public class node
            {
                public int data;
                public node next;
                public node(int d)
                {
                    data = d;
                    next = null;
                }
            }
            public void Add(int new_data)
            {
            node new_node = new node(new_data);
                if (head == null)
                {
                    head = new node(new_data);
                    return;
                }
                new_node.next = null;
            node last = head;
                while (last.next != null)
                    last = last.next;
                last.next = new_node;
                return;
            }
            public void Print()
            {
            node tnode = head;
                while (tnode != null)
                {
                    Console.WriteLine(tnode.data + " ");
                    tnode = tnode.next;
                }
            }
            public void Delete(int key)
            {
            node temp = head, prev = null;
                if (temp != null && temp.data == key)
                {
                    head = temp.next;
                    return;
                }
                while (temp != null && temp.data != key)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null) return;

                prev.next = temp.next;
            }
            public node sortedMerge(node a, node b)
            {
            node result = null;
                if (a == null)
                    return b;
                if (b == null)
                    return a;

                if (a.data <= b.data)
                {
                    result = a;
                    result.next = sortedMerge(a.next, b);
                }
                else
                {
                    result = b;
                    result.next = sortedMerge(a, b.next);
                }
                return result;
            }
            public node Sort(node h)
            {
                if (h == null || h.next == null)
                {
                    return h;
                }
            node middle = getMiddle(h);
            node nextofmiddle = middle.next;
                middle.next = null;
            node left = Sort(h);
            node right = Sort(nextofmiddle);
            node sortedlist = sortedMerge(left, right);
                return sortedlist;
            }

            public node getMiddle(node h)
            {
                if (h == null)
                    return h;
            node fastptr = h.next;
            node slowptr = h;
                while (fastptr != null)
                {
                    fastptr = fastptr.next;
                    if (fastptr != null)
                    {
                        slowptr = slowptr.next;
                        fastptr = fastptr.next;
                    }
                }
                return slowptr;
            }
            public int Search(node head, int x)
            {
                int count = -1;
            node current = head;
                while (current != null)
                {
                    count++;
                    if (current.data == x)
                    {
                        return count;
                    }
                    current = current.next;
                }
                return count;
            }
            public int Number_of_Elements()
            {
            node temp = head;
                int count = 0;
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;
            }
            public int Search_Nth_Index(int index)
            {
            node current = head;
                int count = 0;
                while (current != null)
                {
                    if (count == index)
                        return current.data;
                    count++;
                    current = current.next;
                }
                //Debug.Assert(false);
                return 0;
            }
            public void Insert_Nth_Place(int data, int position)
            {

            node node = new node(data);
                node.next = null;
                if (this.head == null)
                {
                    if (position != 0)
                    {
                        return;
                    }
                    else
                    {
                        this.head = node;
                    }
                }
                if (head != null && position == 0)
                {
                    node.next = this.head;
                    this.head = node;
                    return;
                }
            node current = this.head;
            node previous = null;
                int i = 0;
                while (i < position)
                {
                    previous = current;
                    current = current.next;
                    if (current == null)
                    {
                        break;
                    }
                    i++;
                }
            }
        }
    }


