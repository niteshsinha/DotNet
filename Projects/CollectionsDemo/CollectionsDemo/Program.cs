using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i;
            CollectionsDLL.CustomDLL obj = new CollectionsDLL.CustomDLL();
            // adding the data via adddata method
            for (i = 1; i <= 10;i++ )
                      obj.addata(i*10);
            //adding data via indexer
            obj[1] = "nitesh";
            obj[2] = 300;
            obj[3] = 400;


            //displaying the data
            obj.display();

            //displaying the count of the data
            Console.WriteLine("\n The count of the data is: {0}",obj.count);


            //removing the first five elements
            //for (i = 1; i <= 4; i++)
                obj.removedata(10);
                obj.removedata(50);
                obj.removedata(100);

            //displaying the data again
            Console.WriteLine("After deleting the data...");
            obj.display();

            Console.Read();

        }
    }
}