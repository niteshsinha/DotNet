using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    public class Program3
    {
        public static void Main(string[] args)
        {
            CollectionsDLL.Client1 c1 = new CollectionsDLL.Client1();
            c1.call1();
            c1.show();

            CollectionsDLL.Client2 c2 = new CollectionsDLL.Client2();
            c2.call2();
            c2.show();

            Console.Read();
        }

    }
}
