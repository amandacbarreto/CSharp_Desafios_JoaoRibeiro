namespace Desafio005
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
            this.btn_adivinhar = new System.Windows.Forms.Button();
            this.lbl_informacao = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_adivinhar
            // 
            this.btn_adivinhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adivinhar.Location = new System.Drawing.Point(70, 132);
            this.btn_adivinhar.Name = "btn_adivinhar";
            this.btn_adivinhar.Size = new System.Drawing.Size(100, 32);
            this.btn_adivinhar.TabIndex = 0;
            this.btn_adivinhar.Text = "Iniciar";
            this.btn_adivinhar.UseVisualStyleBackColor = true;
            this.btn_adivinhar.Click += new System.EventHandler(this.btn_adivinhar_Click);
            // 
            // lbl_informacao
            // 
            this.lbl_informacao.AllowDrop = true;
            this.lbl_informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacao.Location = new System.Drawing.Point(12, 9);
            this.lbl_informacao.Name = "lbl_informacao";
            this.lbl_informacao.Size = new System.Drawing.Size(223, 83);
            this.lbl_informacao.TabIndex = 1;
            this.lbl_informacao.Text = "Adivinhe o numero!";
            this.lbl_informacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(70, 95);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 31);
            this.txt_numero.TabIndex = 2;
            this.txt_numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_numero_KeyDown);
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 187);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_informacao);
            this.Controls.Add(this.btn_adivinhar);
            this.Name = "Form1";
            this.Text = "Qual o número?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adivinhar;
        private System.Windows.Forms.Label lbl_informacao;
        private System.Windows.Forms.TextBox txt_numero;
    }
}

