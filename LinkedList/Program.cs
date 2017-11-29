using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList examList = new LList();
            examList.Add(3);
            Console.WriteLine("Added 3");
            examList.Add(5);
            Console.WriteLine("Added 5");
            examList.Add(4);
            Console.WriteLine("Added 4");
            examList.Add(10);
            Console.WriteLine("Added 10");
            examList.Add(7);
            Console.WriteLine("Added 7");
            examList.Add(2);
            Console.WriteLine("Added 2");
            examList.Delete(1);
            Console.WriteLine("Deleted value at index 1");
            Console.WriteLine("Retrieving value at index 1 : " + examList.Retrieve(1));
            Console.WriteLine("Merging values at indexes 2 and 4 : " + examList.Merge(2,4));
            Console.ReadLine();
        }
    }
}
