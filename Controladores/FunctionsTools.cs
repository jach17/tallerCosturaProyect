using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controladores
{
    public class FunctionsTools :Form
    {
        public static Boolean ValidateTextBox(TextBox txt)
        {
            if (txt.Text!="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ClearTextBox(TextBox txt)
        {
            txt.Text = "";
        }

    }
}
