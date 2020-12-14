using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login belep = new Login();
           

            this.Controls.Add(belep);
            belep.Top =
                150;
            belep.Left = 534 / 2;


        }
        



    }
}
