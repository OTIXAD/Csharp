using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form1 : Form
    {
        int total = 0, pago = 0, cambio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                total = total + 100;
                textBoxtotal.Text=total.ToString();
            }
            else
            {
                total = total - 100;
                textBoxtotal.Text = total.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                total = total + 70;
                textBoxtotal.Text = total.ToString();
            }
            else
            {
                total = total - 70;
                textBoxtotal.Text = total.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                total = total + 120;
                textBoxtotal.Text = total.ToString();
            }
            else
            {
                total = total - 120;
                textBoxtotal.Text = total.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                total = total + 80;
                textBoxtotal.Text = total.ToString();
            }
            else
            {
                total = total - 80;
                textBoxtotal.Text = total.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                total = total + 40;
                textBoxtotal.Text = total.ToString();
            }
            else
            {
                total = total - 40;
                textBoxtotal.Text = total.ToString();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                total = total + 90;
                textBoxtotal.Text = total.ToString();
            }
            else
            {
                total = total - 90;
                textBoxtotal.Text = total.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pago = Convert.ToInt32(textBox1.Text);
            if (pago < total)
            {
                MessageBox.Show("Fondos insuficientes");
            }
            else
            {
                cambio = pago - total;
                MessageBox.Show("El cambio es de: " + cambio);
                checkBox1.Checked = false;
                checkBox2.Checked = false; 
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                total = 0;
                pago = 0;
                cambio = 0;
                textBox1.Clear();
                textBoxtotal.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("Seguro que desas cancelar?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                total = 0;
                pago = 0;
                cambio = 0;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                textBox1.Clear();
                textBoxtotal.Clear();
            }
        }

        private void textBoxtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
