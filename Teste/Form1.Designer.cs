namespace Teste
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
            this.btnChaveiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnEscolherChave = new System.Windows.Forms.Button();
            this.lblEscolher = new System.Windows.Forms.Label();
            this.btnDestrancar = new System.Windows.Forms.Button();
            this.lblDestrancar = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChaveiro
            // 
            this.btnChaveiro.Location = new System.Drawing.Point(98, 51);
            this.btnChaveiro.Name = "btnChaveiro";
            this.btnChaveiro.Size = new System.Drawing.Size(96, 23);
            this.btnChaveiro.TabIndex = 0;
            this.btnChaveiro.Text = "Pegar chaveiro";
            this.btnChaveiro.UseVisualStyleBackColor = true;
            this.btnChaveiro.Click += new System.EventHandler(this.btnChaveiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(16, 107);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;
            // 
            // btnEscolherChave
            // 
            this.btnEscolherChave.Enabled = false;
            this.btnEscolherChave.Location = new System.Drawing.Point(98, 153);
            this.btnEscolherChave.Name = "btnEscolherChave";
            this.btnEscolherChave.Size = new System.Drawing.Size(96, 23);
            this.btnEscolherChave.TabIndex = 3;
            this.btnEscolherChave.Text = "Escolher chave";
            this.btnEscolherChave.UseVisualStyleBackColor = true;
            this.btnEscolherChave.Visible = false;
            this.btnEscolherChave.Click += new System.EventHandler(this.btnEscolherChave_Click);
            // 
            // lblEscolher
            // 
            this.lblEscolher.AutoSize = true;
            this.lblEscolher.Location = new System.Drawing.Point(19, 187);
            this.lblEscolher.Name = "lblEscolher";
            this.lblEscolher.Size = new System.Drawing.Size(0, 13);
            this.lblEscolher.TabIndex = 4;
            // 
            // btnDestrancar
            // 
            this.btnDestrancar.Enabled = false;
            this.btnDestrancar.Location = new System.Drawing.Point(98, 246);
            this.btnDestrancar.Name = "btnDestrancar";
            this.btnDestrancar.Size = new System.Drawing.Size(103, 23);
            this.btnDestrancar.TabIndex = 5;
            this.btnDestrancar.Text = "Destrancar e abrir";
            this.btnDestrancar.UseVisualStyleBackColor = true;
            this.btnDestrancar.Visible = false;
            this.btnDestrancar.Click += new System.EventHandler(this.btnDestrancar_Click);
            // 
            // lblDestrancar
            // 
            this.lblDestrancar.AutoSize = true;
            this.lblDestrancar.BackColor = System.Drawing.SystemColors.Control;
            this.lblDestrancar.ForeColor = System.Drawing.Color.Green;
            this.lblDestrancar.Location = new System.Drawing.Point(19, 282);
            this.lblDestrancar.Name = "lblDestrancar";
            this.lblDestrancar.Size = new System.Drawing.Size(0, 13);
            this.lblDestrancar.TabIndex = 6;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(181, 345);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(118, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "github.com/thommattos";
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Projetado por:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(184, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(115, 13);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "thommattos@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 367);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lblDestrancar);
            this.Controls.Add(this.btnDestrancar);
            this.Controls.Add(this.lblEscolher);
            this.Controls.Add(this.btnEscolherChave);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChaveiro);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChaveiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnEscolherChave;
        private System.Windows.Forms.Label lblEscolher;
        private System.Windows.Forms.Button btnDestrancar;
        private System.Windows.Forms.Label lblDestrancar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

