using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CollectionsDLL
{
    public class ClassMain:IEnumerable
    {
        ArrayList arr = new ArrayList();
        public void initialize()
        {
            arr.Add(new Class1());
            arr.Add(new Class2());
            arr.Add(new Class3());
        }
        public void call()
        {
            foreach (ClassBase item in arr)
            {
                item.getMessage(); 
            }       
        }



        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        #endregion
    }
}
