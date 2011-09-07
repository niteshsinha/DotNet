using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDLL
{
    public class Client2
    {
        ClassGen<string> ob2 = new ClassGen<string>();
        public void call2()
        {
            ob2.addData("One");
            ob2.addData("Two");
            ob2.addData("Three");
            ob2.addData("Four");
            ob2.addData("Five");
        }
        public void show()
        {
            ob2.display();
        }
    }
}
