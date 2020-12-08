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

            listView1.Clear();
            if (textBox1.Text != null && textBox1.Text.Length >=3)
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
                            
                            listView1.Items.Add(child.InnerText);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Hibás keresési érték!");
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Audi";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Mazda";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Porsche";
        }
    }
}
