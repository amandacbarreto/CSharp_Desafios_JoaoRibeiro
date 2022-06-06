
namespace Desafio004
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_algorismos = new System.Windows.Forms.TextBox();
            this.txt_letras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Só algorismos...";
            // 
            // txt_algorismos
            // 
            this.txt_algorismos.Location = new System.Drawing.Point(15, 35);
            this.txt_algorismos.Name = "txt_algorismos";
            this.txt_algorismos.Size = new System.Drawing.Size(149, 20);
            this.txt_algorismos.TabIndex = 1;
            this.txt_algorismos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_algorismos_KeyPress);
            // 
            // txt_letras
            // 
            this.txt_letras.Location = new System.Drawing.Point(15, 85);
            this.txt_letras.Name = "txt_letras";
            this.txt_letras.Size = new System.Drawing.Size(149, 20);
            this.txt_letras.TabIndex = 3;
            this.txt_letras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_letras_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Só letras...";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(185, 125);
            this.Controls.Add(this.txt_letras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_algorismos);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_algorismos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_algorismos;
        private System.Windows.Forms.TextBox txt_letras;
        private System.Windows.Forms.Label label6;
    }
}

