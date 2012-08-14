namespace testevisual
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.compra = new System.Windows.Forms.TextBox();
            this.adiciona = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para Comprar:";
            // 
            // compra
            // 
            this.compra.Location = new System.Drawing.Point(33, 40);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(257, 20);
            this.compra.TabIndex = 1;
            // 
            // adiciona
            // 
            this.adiciona.Location = new System.Drawing.Point(315, 38);
            this.adiciona.Name = "adiciona";
            this.adiciona.Size = new System.Drawing.Size(75, 23);
            this.adiciona.TabIndex = 2;
            this.adiciona.Text = "Adicionar";
            this.adiciona.UseVisualStyleBackColor = true;
            this.adiciona.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(33, 86);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(257, 173);
            this.lista.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(449, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 296);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adiciona);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programa de Lista de Compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

       
        private System.Windows.Forms.TextBox compra;
        private System.Windows.Forms.Button adiciona;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Panel panel1;

    }
}

