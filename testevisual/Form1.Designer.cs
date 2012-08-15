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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.compra = new System.Windows.Forms.TextBox();
            this.adiciona = new System.Windows.Forms.Button();
            this.Conflito = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para Comprar :";
            // 
            // compra
            // 
            this.compra.BackColor = System.Drawing.SystemColors.InfoText;
            this.compra.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.compra.Location = new System.Drawing.Point(25, 76);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(257, 28);
            this.compra.TabIndex = 1;
            // 
            // adiciona
            // 
            this.adiciona.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adiciona.Location = new System.Drawing.Point(321, 51);
            this.adiciona.Name = "adiciona";
            this.adiciona.Size = new System.Drawing.Size(112, 53);
            this.adiciona.TabIndex = 2;
            this.adiciona.Text = "Adicionar";
            this.adiciona.UseVisualStyleBackColor = true;
            this.adiciona.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conflito
            // 
            this.Conflito.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conflito.Location = new System.Drawing.Point(321, 221);
            this.Conflito.Name = "Conflito";
            this.Conflito.Size = new System.Drawing.Size(112, 82);
            this.Conflito.TabIndex = 4;
            this.Conflito.Text = "Apagar";
            this.Conflito.UseVisualStyleBackColor = true;
            this.Conflito.Click += new System.EventHandler(this.button2_Click);
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.InfoText;
            this.lista.Font = new System.Drawing.Font("AR DESTINE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 43;
            this.lista.Location = new System.Drawing.Point(25, 131);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(257, 176);
            this.lista.TabIndex = 5;
            // 
            // pictureBox1
            // 

           
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(803, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.Conflito);
            this.Controls.Add(this.adiciona);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programa de Lista de Compras";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

       
        private System.Windows.Forms.TextBox compra;
        private System.Windows.Forms.Button adiciona;
        private System.Windows.Forms.Button Conflito;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

