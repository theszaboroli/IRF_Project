using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace auto
{
    

    public partial class Form2 : Form
    {
        public string theDate;
        public Form2()
        {
            InitializeComponent();
            UserControl1 kuponkod = new UserControl1();
            this.Controls.Add(kuponkod);
            kuponkod.Left = 350;
            kuponkod.Top = 130;

            date datum = new date();
            this.Controls.Add(datum);
            datum.Top = 170;
            datum.Left = 70;
           theDate = datum.Value.ToShortDateString();

            
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty && textBox3.Text != string.Empty && textBox3.Text != string.Empty)
            if (textBox4.Text != string.Empty && textBox3.Text != string.Empty && textBox3.Text != string.Empty)
            {
                if (textBox4.Text == "József Attila út 126" || textBox4.Text == "Sohanincs utca 53" || textBox4.Text == "Remélem nem bukok meg utca 2")
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.InitialDirectory = Application.StartupPath;
                    sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
                    sfd.DefaultExt = "csv";
                    sfd.AddExtension = true;
                    if (sfd.ShowDialog() != DialogResult.OK) return;
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {




                        sw.Write(textBox1.Text);
                        sw.Write(";");
                        sw.Write(textBox4.Text);
                        sw.Write(";");
                        sw.Write(theDate);
                        sw.Write(";");
                        sw.Write(textBox2.Text);
                        sw.Write(";");
                        sw.Write(textBox3.Text);
                        sw.Write(";");
                        sw.WriteLine(); 

                        MessageBox.Show("Sikeres mentés!");
                    }
                }
                else
                {
                    MessageBox.Show("Érvénytelen cím!");
                }
            }

            else
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
            }
        }
        //private string _ertek;
        //public string Ertek
        //{

        //    get { return _ertek; }
        //    set
        //    {
        //        if (textBox5.Text == "textBox5")
                
        //            _ertek = "100%";
                
        //    }
        //}


      

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button7.Text = "Mai ajánlatunk";


        }

   

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button7.Text = "20% kedvezmény: OOSDO1";
        }
        private bool Validemail(string email)
        {
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); 
            return r.IsMatch(email);
        }
        private void textBox3_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox3, "");

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!Validemail(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Érvénytelen email cím");
            }
        }
    }
    
}
