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
            this.comprar = new System.Windows.Forms.TextBox();
            this.adiciona = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListView();
            this.apaga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para Comprar";
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(25, 29);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(229, 20);
            this.comprar.TabIndex = 1;
            // 
            // adiciona
            // 
            this.adiciona.Location = new System.Drawing.Point(448, 26);
            this.adiciona.Name = "adiciona";
            this.adiciona.Size = new System.Drawing.Size(75, 23);
            this.adiciona.TabIndex = 2;
            this.adiciona.Text = "adicionar";
            this.adiciona.UseVisualStyleBackColor = true;
            this.adiciona.Click += new System.EventHandler(this.adiciona_Click);
            // 
            // lista
            // 
            this.lista.Location = new System.Drawing.Point(78, 92);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(371, 191);
            this.lista.TabIndex = 3;
            this.lista.UseCompatibleStateImageBehavior = false;
            // 
            // apaga
            // 
            this.apaga.Location = new System.Drawing.Point(448, 315);
            this.apaga.Name = "apaga";
            this.apaga.Size = new System.Drawing.Size(75, 23);
            this.apaga.TabIndex = 4;
            this.apaga.Text = "apagar";
            this.apaga.UseVisualStyleBackColor = true;
            this.apaga.Click += new System.EventHandler(this.apaga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 362);
            this.Controls.Add(this.apaga);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.adiciona);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comprar;
        private System.Windows.Forms.Button adiciona;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.Button apaga;
    }
}

