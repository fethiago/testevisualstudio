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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "admin") || ((textBox1.Text == "felipe") && (textBox2.Text == "123")))
            {
                Form1 tela = new Form1();
                tela.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Invalidos", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
