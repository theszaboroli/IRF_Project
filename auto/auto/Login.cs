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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Kérlek írd be a jelszót!");

                }
                else if (textBox1.Text == "IRF")
                {
                    Form2 home = new Form2();
                    Form1 obj = (Form1)Application.OpenForms["Form1"];
                    obj.Hide();

                    home.Show();
                }

                else if (textBox1.Text == "EasterEGG")
                {
                    Form1 obj = (Form1)Application.OpenForms["Form1"];
                    obj.BackColor = Color.Fuchsia;

                }

                else
                {
                    MessageBox.Show("Rossz jelszó!");
                }
            }
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
                Form1 obj = (Form1)Application.OpenForms["Form1"];
                obj.Hide();

                home.Show();
            }

            else if (textBox1.Text == "EasterEGG")
            {
                Form1 obj = (Form1)Application.OpenForms["Form1"];
                obj.BackColor = Color.Fuchsia;

            }

            else
            {
                MessageBox.Show("Rossz jelszó!");
            }
        }
    }
}
