using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace StringBSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            textBox2.Text = "Hallo " + name + ",\r\nschön dich zu sehen. Heute schon Latein gelernt??";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int nameslaenge = name.Length;
            textBox3.Text = "Dein Name besteht aus " + nameslaenge.ToString() + " Zeichen.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            char zeichen;
            for (int i = 0; i < name.Length; i++)
            {
                zeichen = name[i];
                if ((zeichen == '-') || (zeichen == ' '))
                {
                    textBox4.Text = name.ToString() + " ist ein Doppelname.";
                    break;
                }
                else
                {
                    textBox4.Text = name.ToString() + " ist kein Dopplename.";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            char zeichen;
            int counter = 0;
            for (int i = 0; i < name.Length; i++)
            {
                zeichen = name[i];
                if ((zeichen == 'a') || (zeichen == 'e') || (zeichen == 'i') || (zeichen == 'o') || (zeichen == 'u') || (zeichen == 'ä') || (zeichen == 'ö') || (zeichen == 'ü'))
                {
                    counter ++;
                }
            }
            textBox5.Text = name.ToString() + " hat " + counter.ToString() + " Vokale.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int length = name.Length;
            int[] turned = new int[length];
            char character;
            string text = "";

            for (int i = 0; i < length; i++)
            {
                character = name[length - (i + 1)];
                text = text + character;
                textBox6.Text = text;
            }            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string ausgabe = name;

            ausgabe = ausgabe.Replace("ä", "ae");
            ausgabe = ausgabe.Replace("ö", "oe");
            ausgabe = ausgabe.Replace("ü", "ue");
            ausgabe = ausgabe.Replace("Ä", "Ae");
            ausgabe = ausgabe.Replace("Ö", "Oe");
            ausgabe = ausgabe.Replace("Ü", "Ue");
            ausgabe = ausgabe.Replace("ß", "ss");
            ausgabe = ausgabe.Replace("ẞ", "SS");
            textBox7.Text = ausgabe;
            
        }
    }
}