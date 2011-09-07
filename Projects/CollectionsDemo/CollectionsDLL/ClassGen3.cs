using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDLL
{
   public class ClassGen3<TKey,TValue>:Dictionary<TKey,TValue>
    {
            Dictionary<TKey, TValue> mydict = new Dictionary<TKey,TValue>();

       public void addData(TKey key,TValue val)
       {
           mydict.Add(key, val);
       }
       public void display()
       {
           foreach (KeyValuePair<TKey,TValue> k in mydict)
           {
               Console.WriteLine("The Key-Value pair is : {0}-{1}",k.Key,k.Value);
           }

       }

    }
}
