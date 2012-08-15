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

        private void adiciona_Click(object sender, EventArgs e)
        {
            lista.Items.Add(compra.Text);
        }

       
          

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Add(compra.Text);
            compra.Clear();
            compra.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogo;
            int b = lista.Items.Count;

            if (b == 0)
                MessageBox.Show("A lista está Vazia!!! \n Adicione primeiro um item \n e depois selecione para remove-lo", "**Excluindo item da lista**", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int c = lista.SelectedItems.Count;
                if (c > 0)
                {
                    dialogo = MessageBox.Show("Deseja realmente excluir?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogo == System.Windows.Forms.DialogResult.Yes)
                        lista.Items.Remove(lista.SelectedItem);
                }
                else
                    MessageBox.Show("Selecione um item para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir todos os itens da lista", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lista.Items.Clear();
            }
           

            
        }
    }
}
