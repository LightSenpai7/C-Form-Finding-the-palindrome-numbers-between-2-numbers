using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ilksayi;
        int ikincisayi;
        int i;
        int normalsayi;
        int terssayi;
        int rem;
        private void button1_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToInt32(textBox1.Text);

            ikincisayi = Convert.ToInt32(textBox2.Text);
             for (i = ilksayi; i <= ikincisayi; i++)
            {
                normalsayi = i;
                terssayi = 0;

                while ((System.Convert.ToInt32(normalsayi) != 0)) 
                {
                    rem = normalsayi % 10;
                    normalsayi = normalsayi / 10;
                    terssayi = terssayi * 10 + rem;
                }

                if (i == terssayi)
                {
                    listBox1.Items.Add(i);
                }
                      
            }
         


        }
    }
    }
 
