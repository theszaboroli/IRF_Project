using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

           


            }

        private bool _value;
        public bool Value
        {
            get { return _value; }
            set
            {
                _value = value;
                if (textBox1.Text=="OOSDO1")
                {
                    _value = true;
                }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {



    if (textBox1.Text == "OOSDO1")
    {
        button1.Text = "20%";
      
            }
            else
            {
                button1.Text = "0%";
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_value == true)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;

            }
        }
    }
}
