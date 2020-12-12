using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    class discount : Button
    {
        private string _ertek;
        TextBox t = Application.OpenForms["Form2"].Controls["textBox2"] as TextBox;
        public string Ertek
        {
           
            get { return _ertek; }
            set
            {
                if (t.Text == "textBox5")
                {
                    _ertek = "100%";
                }
            }
        }


        public discount()
        {
            Height = 50;
            Width = 200;
            BackColor = Color.Black;
            Text = "Kattints ide a kedvezmény kiszámításához!";
            ForeColor = Color.Red;


        }
    }
}
