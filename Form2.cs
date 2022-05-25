using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_shoop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Items.Add("Strawberries");
                comboBox1.Items.Add("Lamon");
                comboBox1.Items.Add("Orang");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        
            if (checkBox2.Checked)
            {
                comboBox2.Items.Add("Mohito Lemon");
                comboBox2.Items.Add("Mohito Mix");
                comboBox2.Items.Add("Mohito Mint");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                comboBox4.Items.Add("Ice Cream Chocolate");
                comboBox4.Items.Add("Ice Cream Caramel");
                comboBox4.Items.Add("Ice Cream Oreo");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                comboBox5.Items.Add("cold moca");
                comboBox5.Items.Add("hot moca");
                comboBox5.Items.Add("Frappuccino");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {

                comboBox3.Items.Add("American Coffee");
                comboBox3.Items.Add("Turkish Coffee");
                comboBox3.Items.Add("Saudi Coffee");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Pink;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Green;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Yellow;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox6.Text;

            Menu.Text = "MENU";
            Menu.Items.Add("MENU");
            Menu.Items.Add(checkBox1.Text);
            Menu.Items.Add(checkBox2.Text);
            Menu.Items.Add(checkBox3.Text);
            Menu.Items.Add(checkBox4.Text);
            Menu.Items.Add(checkBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order Is " + comboBox1.Text);
            MessageBox.Show("Your Order Is " + comboBox2.Text);
            MessageBox.Show("Your Order Is " + comboBox3.Text);
            MessageBox.Show("Your Order Is " + comboBox4.Text);
            MessageBox.Show("Your Order Is " + comboBox5.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total1.Clear();
            total2.Clear();
            total3.Clear();
            total4.Clear();
            total5.Clear();
            total.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Menu.ForeColor = cd.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            Menu.Font = fd.Font;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double t1, t2, t3, t4, t5, t6, t7, t8, t9, t10;
            double tt1, tt2, tt3, tt4, tt5;

            t1 = Convert.ToDouble(numericUpDown1.Value);
            t2 = Convert.ToDouble(textBox1.Text);
            total1.Text = (t1 * t2).ToString();

            t3 = Convert.ToDouble(numericUpDown2.Value);
            t4 = Convert.ToDouble(textBox2.Text);
            total2.Text = (t3 * t4).ToString();

            t5 = Convert.ToDouble(numericUpDown3.Value);
            t6 = Convert.ToDouble(textBox3.Text);
            total3.Text = (t5 * t6).ToString();

            t7 = Convert.ToDouble(numericUpDown4.Value);
            t8 = Convert.ToDouble(textBox4.Text);
            total4.Text = (t7 * t8).ToString();

            t9 = Convert.ToDouble(numericUpDown5.Value);
            t10 = Convert.ToDouble(textBox5.Text);
            total5.Text = (t9 * t10).ToString();
            tt1 = Convert.ToDouble(total1.Text);
            tt2 = Convert.ToDouble(total2.Text);
            tt3 = Convert.ToDouble(total3.Text);
            tt4 = Convert.ToDouble(total4.Text);
            tt5 = Convert.ToDouble(total5.Text);
            total.Text = (tt1 + tt2 + tt3 + tt4 + tt5).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog fc = new ColorDialog();
            fc.ShowDialog();
            this.BackColor = fc.Color;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "2.50";
            textBox2.Text = "1.50";
            textBox3.Text = "2.00";
            textBox4.Text = "2.50";
            textBox5.Text = "1.00";
        }
    }
}
