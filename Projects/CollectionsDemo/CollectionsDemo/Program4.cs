using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    public class Program4
    {
        public static void Main(string[] args)
        {
            
            CollectionsDLL.ClassGen2<string> ob = new CollectionsDLL.ClassGen2<string>();
            ob[0] = "Nitesh Sinha";
            ob[1] = "BTM Layout";
            ob[2] = "Bangalore";

            Console.WriteLine(ob[0]);
            Console.WriteLine(ob[1]);
            Console.WriteLine(ob[2]);

            Console.Read();
            
            
        }
    }
}
