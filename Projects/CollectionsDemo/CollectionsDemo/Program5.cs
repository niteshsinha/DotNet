using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
   public class Program5
    {
       public static void Main(string[] args)
       {
           CollectionsDLL.ClassGen3<int, string> ob = new CollectionsDLL.ClassGen3<int, string>();
           // adding the data in the dictionary
           ob.addData(10, "Nitesh");
           ob.addData(20, "Akash");
           ob.addData(30, "Akriti");
           ob.addData(40, "Reetika");

           //displaying the data
           ob.display();

           Console.Read();

       }
    }
}
