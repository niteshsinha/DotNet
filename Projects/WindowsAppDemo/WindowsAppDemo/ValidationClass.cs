using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsAppDemo
{
   public class ValidationClass
    {
        //check for blank value
        public bool EmptyBox(System.Windows.Forms.TextBox txtbx)
        {
            if (txtbx.Text == "")
                return false;
            else
                return true;
        }
    }
}
