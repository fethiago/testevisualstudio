using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testevisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox1.Items.Count;

            if (a == 0)
                MessageBox.Show("A lista está Vazia!!! \n Adicione primeiro um item \n e depois selecione para remove-lo", "**Excluindo item da lista**", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
