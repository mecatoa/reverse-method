using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0reverse0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> MyList = new LinkedList<string>();

            MyList.AddFirst("OK");
            MyList.AddLast("K.O");
            LinkedListNode<String> MyNode = new LinkedListNode<string>("Done");
            MyList.AddFirst(MyNode);
            MyList.AddBefore(MyNode, "Tool");
            MyList.AddAfter(MyNode, "Cool");

            Console.WriteLine("The LinkedList Before Reversing: ");

            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The LinkedList After Reversing: ");

            foreach (var item in MyList.Reverse())
            {
                Console.WriteLine(item);
            }
        }
    }
}
