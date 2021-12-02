using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in checkedListBox1.CheckedItems)
                listBox1.Items.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,
                sum = 0;
            for (i = 0; i < listBox1.Items.Count; i++)
                sum = sum + Convert.ToInt32(listBox1.Items[i]);
            label2.Text = sum.ToString();
            if (sum == 50)
            {
                timer1.Enabled = false;
            }
        }

        int ot = 120;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ot--;
             label4.Text = "У вас осталось:" + Convert.ToString(ot) + " сек";
            if (ot == 00)
            {
                timer1.Enabled = false;
                label4.Text = "Время вышло";
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(" ", string.Empty);
        }


        public void symbol(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (e.KeyChar <= 47 || e.KeyChar >= 58) && l != '\b'  && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            symbol(sender, e);
        }
    }
}
