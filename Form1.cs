using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_Proyecto_2
{
    public partial class Form1 : Form
    {
        private double v1;
        private double v2;
        private double rslt;
        private int oper;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible=true;
            Size = new Size(820,695);
            panel1.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            Size = new Size(820, 695);
            panel1.Visible = false;
            panel2.Visible = false;
            panel7.Visible = false;
        }

        private void basicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Size = new Size(430, 660);
            panel2.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }
        #region basica num
        private void button21_Click(object sender, EventArgs e)
        {
            //0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button27_Click(object sender, EventArgs e)
        { //1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button28_Click(object sender, EventArgs e)
        {//2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button25_Click(object sender, EventArgs e)
        {//3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {//4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {//5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {//6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button20_Click(object sender, EventArgs e)
        {//7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {//8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {//9
            textBox1.Text = textBox1.Text + "9";
        }
        #endregion

        private void button9_Click(object sender, EventArgs e)
        {
            //limpiar
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //suma (1)
            oper = 1;
            v1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + " + ";
            label1.Visible = true;
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //resta (2)
            oper = 2;
            v1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text+" - ";
            label1.Visible = true;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //mult (3)
            oper = 3;
            v1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + " * ";
            label1.Visible = true;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //dividir

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //raiz (4)
            oper = 4;
            v1 = Convert.ToDouble(textBox1.Text);
            label1.Text = "√ "+textBox1.Text;
            label1.Visible = true;
            double raiz = Math.Sqrt(v1);

            textBox1.Text = raiz.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //igual
            if (textBox1.Text == "")
            {
                v2 = 0;
            }
            v2 = Convert.ToDouble(textBox1.Text);
            switch (oper)
            {
                case 1:
                    rslt = v1 + v2;
                    break;
                case 2:
                    rslt = v1 - v2;
                    break;
                case 3:
                    rslt = v1 * v2;
                    break;
            }
            label1.Visible = false;
            textBox1.Text = rslt.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //uno menos

            string v = textBox1.Text;
            string aux="";
            int n = v.Length,j=0;
            textBox1.Text = "";
            foreach(char i in v)
            {
                if (j < n-1)
                {
                    aux = aux + i;
                }
                else
                {

                }
                j++;

            }
            textBox1.Text += aux;

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel1.Visible = true;
            Size = new Size(1050, 695);
            panel4.Visible = false;
            panel2.Visible = false;
        }
    }
}
