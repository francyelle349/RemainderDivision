namespace RestoDaDivisao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dividendo = new System.Windows.Forms.Label();
            this.divisor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.resto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dividendo
            // 
            this.dividendo.AutoSize = true;
            this.dividendo.Location = new System.Drawing.Point(2, 29);
            this.dividendo.Name = "dividendo";
            this.dividendo.Size = new System.Drawing.Size(58, 13);
            this.dividendo.TabIndex = 1;
            this.dividendo.Text = "Dividendo:";
            this.dividendo.Click += new System.EventHandler(this.label1_Click);
            // 
            // divisor
            // 
            this.divisor.AutoSize = true;
            this.divisor.Location = new System.Drawing.Point(210, 32);
            this.divisor.Name = "divisor";
            this.divisor.Size = new System.Drawing.Size(42, 13);
            this.divisor.TabIndex = 2;
            this.divisor.Text = "Divisor:";
            this.divisor.Click += new System.EventHandler(this.divisor_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Realizar Divisão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResto
            // 
            this.txtResto.Location = new System.Drawing.Point(258, 65);
            this.txtResto.Name = "txtResto";
            this.txtResto.ReadOnly = true;
            this.txtResto.Size = new System.Drawing.Size(115, 20);
            this.txtResto.TabIndex = 5;
            this.txtResto.Text = "0";
            this.txtResto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // resto
            // 
            this.resto.AutoSize = true;
            this.resto.Location = new System.Drawing.Point(210, 69);
            this.resto.Name = "resto";
            this.resto.Size = new System.Drawing.Size(38, 13);
            this.resto.TabIndex = 6;
            this.resto.Text = "Resto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(385, 94);
            this.Controls.Add(this.resto);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.divisor);
            this.Controls.Add(this.dividendo);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RestoDaDivisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dividendo;
        private System.Windows.Forms.Label divisor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.Label resto;
    }
}

