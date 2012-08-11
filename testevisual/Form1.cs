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
            lista.Items.Add(comprar.Text);
        }

        private void apaga_Click(object sender, EventArgs e)
        {
          
        }
    }
}
