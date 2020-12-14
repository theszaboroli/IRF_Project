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

        private string _kuponkod;
        public string Kuponkod{
        get{return _kuponkod;}
        set{


                _kuponkod = value;
                if (_kuponkod=="OOSDO1")
                {
                    textBox1.BackColor = Color.Green;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
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
            Kuponkod = textBox1.Text;
        }
    }
}
