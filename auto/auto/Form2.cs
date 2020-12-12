using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace auto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox4.Clear();
            if (textBox1.Text != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("XMLFile1.xml");
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == textBox1.Text)
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            
                           
                            textBox4.Text = child.InnerText;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("A mező üres!");
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "XVI";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "XI";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "II";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
