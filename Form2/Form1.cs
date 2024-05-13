using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Saludo_Click(object sender, EventArgs e)
        {
            //Aqui va el codigo de lo que va a pasar cuando le de click a boton saludo
            MessageBox.Show("Estas seguro? " + textBoxnombre.Text, "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1 = Convert.ToSingle(textBoxn1.Text);
            float n2 = Convert.ToSingle(textBoxn2.Text);
            float res = n1 + n2;
            MessageBox.Show("El resultado es: " + res);
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            float n1 = Convert.ToSingle(textBoxn1.Text);
            float n2 = Convert.ToSingle(textBoxn2.Text);
            float res = n1 - n2;
            MessageBox.Show("El resultado es: " + res);
        }

        private void BotonDividir_Click(object sender, EventArgs e)
        {
            float n1 = Convert.ToSingle(textBoxn1.Text);
            float n2 = Convert.ToSingle(textBoxn2.Text);
            float res = n1 / n2;
            MessageBox.Show("El resultado es: " + res);
        }

        private void BotonMultiplicar_Click(object sender, EventArgs e)
        {
            float n1 = Convert.ToSingle(textBoxn1.Text);
            float n2 = Convert.ToSingle(textBoxn2.Text);
            float res = n1 * n2;
            MessageBox.Show("El resultado es: " + res);
        }
    }
}
