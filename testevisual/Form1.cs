﻿using System;
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
            int b = lista.Items.Count;

            if (b == 0)
                MessageBox.Show("A lista está Vazia!!! \n Adicione primeiro um item \n e depois selecione para remove-lo", "**Excluindo item da lista**", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                
                lista.Items.Remove(lista.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
