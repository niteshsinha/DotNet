using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDLL
{
   public class Client1
    {
       ClassGen<int> ob1 = new ClassGen<int>();

       public void call1()
       {
           ob1.addData(10);
           ob1.addData(20);
           ob1.addData(30);
           ob1.addData(40);
           ob1.addData(50);
       }
       public void show()
       {
           ob1.display();
       }
    }
}
