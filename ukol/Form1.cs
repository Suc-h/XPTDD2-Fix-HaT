using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ShowIcon = false;
            this.Text = "UnitTestUkolDva";
        }

        Hrac hrac;
        NPC npc;


              


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                hrac = new Hrac(textBox1.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedIndex, comboBox3.SelectedIndex, comboBox4.SelectedIndex);
                button2.Enabled = true;
                //button3.Enabled = true;
                button4.Enabled = true;
                label6.Text = hrac.ToString();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            npc = new NPC(textBox1.Text, textBox2.Text, radioButton1.Checked ? true : false);
            npc.ZmenaPozice();
            label6.Text = npc.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            hrac.PridejXP((int)numericUpDown1.Value);
            label6.Text = hrac.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            hrac.ZmenaPozice();
            label6.Text = hrac.ToString();
        }
    }
}
