using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            CollectionsDLL.ClassMain ob = new CollectionsDLL.ClassMain();
            ob.initialize();
            ob.call();
            Console.Read();
        }

    }
}
