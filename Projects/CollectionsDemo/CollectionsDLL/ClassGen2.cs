using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDLL
{
    public class ClassGen2<T>
    {
        List <T> li = new List<T>();
          
        public T this[int index]
        {

            get
            {
                return li[index];
            }
            set
            {
                //li[index] = value;
                li.Insert(index, value);
            }
        }

    }
}
