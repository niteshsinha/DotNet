using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDLL
{
    public class ClassGen<T>
    {
        List <T> li= new List<T>();
        public void addData(T data)
        {
            li.Add(data);
        }
        public void display()
        {
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

        }
    }
}
