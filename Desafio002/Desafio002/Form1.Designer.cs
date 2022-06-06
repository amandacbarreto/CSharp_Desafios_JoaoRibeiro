
namespace Desafio002
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
            this.btn_somar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(118, 12);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(26, 20);
            this.btn_somar.TabIndex = 0;
            this.btn_somar.Text = "+";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.operacao);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(9, 61);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 1;
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(12, 12);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 20);
            this.numero1.TabIndex = 2;
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Location = new System.Drawing.Point(150, 12);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(26, 20);
            this.btn_subtrair.TabIndex = 3;
            this.btn_subtrair.Text = "-";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            this.btn_subtrair.Click += new System.EventHandler(this.operacao);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(150, 38);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(26, 20);
            this.btn_dividir.TabIndex = 6;
            this.btn_dividir.Text = ":";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.operacao);
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(12, 38);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 20);
            this.numero2.TabIndex = 5;
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(118, 38);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(26, 20);
            this.btn_multiplicar.TabIndex = 4;
            this.btn_multiplicar.Text = "x";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.operacao);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 125);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_somar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Button btn_multiplicar;
    }
}

