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
        public string Ertek
        {

            get { return _ertek; }
            set
            {
                if (kupon.Text == "OOSDO1")
                {
                    _ertek = "20%";
                }
            }
        }

        public discount()
        {
            Height = 50;
            Width = 200;
            BackColor = Color.Black;
            Text = "Kattintsd ide, hogy kiszámold a kedvezményt!";
            ForeColor = Color.Red;


        }
    }
}
