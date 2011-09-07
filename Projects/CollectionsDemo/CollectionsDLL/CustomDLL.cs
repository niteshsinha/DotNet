using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CollectionsDLL
{
    public class CustomDLL
    {
        ArrayList arr = new ArrayList();

        public void addata(object n)
        {
            arr.Add(n); 
        }
        public void removedata(object n)
        {
            arr.Remove(n);
        }
        public void display()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        // defining a property count
        public int count
        {
            get
            {
                return arr.Count;
            }
            set
            {
                count = arr.Count;
            }
        }
        //defining an indexer
        public object this[int index]
        {
            get
            {
               return arr[index];
            }
            set
            {
                arr[index] = value;
            }

        }
    }
}
