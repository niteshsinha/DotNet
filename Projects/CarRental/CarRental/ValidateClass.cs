using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental
{
    public class ValidateClass
    {

        public bool EmptyBox(System.Windows.Forms.TextBox txt)
        {

                if (txt.Text == "")
                    return false;
                else
                    return true;
        }
         public bool EmptyCombo(System.Windows.Forms.ComboBox cmb)
        {

            if (cmb.SelectedIndex == -1)
                return false;
            else
                return true;

        }

          
       
    }

}
