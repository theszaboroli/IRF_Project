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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kérlek írd be a jelszót!");

            }
            else if (textBox1.Text == "IRF")
            {
                Form2 home = new Form2();

                // Show the settings form

                this.Hide();
                home.Show();
            }

            else if (textBox1.Text == "EasterEGG")
            {
                this.BackColor = Color.Fuchsia;
                
            }

            else
            {
                MessageBox.Show("Rossz jelszó!");
            }
        }
    }
}
