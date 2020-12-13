using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    class kupon: TextBox
    {
        public kupon()
        {
            if (this.Text == "OOSDO1")
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
