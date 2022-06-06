
namespace Desafio003
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_maiusculas = new System.Windows.Forms.CheckBox();
            this.checkBox_algarismos = new System.Windows.Forms.CheckBox();
            this.checkBox_simbolos = new System.Windows.Forms.CheckBox();
            this.numero_char = new System.Windows.Forms.NumericUpDown();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.lista_senhas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numero_char)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° de chars";
            // 
            // checkBox_maiusculas
            // 
            this.checkBox_maiusculas.AutoSize = true;
            this.checkBox_maiusculas.Location = new System.Drawing.Point(255, 73);
            this.checkBox_maiusculas.Name = "checkBox_maiusculas";
            this.checkBox_maiusculas.Size = new System.Drawing.Size(120, 17);
            this.checkBox_maiusculas.TabIndex = 3;
            this.checkBox_maiusculas.Text = "Usar MAIÚSCULAS";
            this.checkBox_maiusculas.UseVisualStyleBackColor = true;
            // 
            // checkBox_algarismos
            // 
            this.checkBox_algarismos.AutoSize = true;
            this.checkBox_algarismos.Location = new System.Drawing.Point(255, 96);
            this.checkBox_algarismos.Name = "checkBox_algarismos";
            this.checkBox_algarismos.Size = new System.Drawing.Size(100, 17);
            this.checkBox_algarismos.TabIndex = 4;
            this.checkBox_algarismos.Text = "Usar algarismos";
            this.checkBox_algarismos.UseVisualStyleBackColor = true;
            // 
            // checkBox_simbolos
            // 
            this.checkBox_simbolos.AutoSize = true;
            this.checkBox_simbolos.Location = new System.Drawing.Point(255, 119);
            this.checkBox_simbolos.Name = "checkBox_simbolos";
            this.checkBox_simbolos.Size = new System.Drawing.Size(93, 17);
            this.checkBox_simbolos.TabIndex = 5;
            this.checkBox_simbolos.Text = "Usar símbolos";
            this.checkBox_simbolos.UseVisualStyleBackColor = true;
            // 
            // numero_char
            // 
            this.numero_char.Location = new System.Drawing.Point(255, 30);
            this.numero_char.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numero_char.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numero_char.Name = "numero_char";
            this.numero_char.Size = new System.Drawing.Size(120, 20);
            this.numero_char.TabIndex = 6;
            this.numero_char.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(255, 233);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(120, 43);
            this.btn_gerar.TabIndex = 7;
            this.btn_gerar.Text = "GERAR";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // lista_senhas
            // 
            this.lista_senhas.FormattingEnabled = true;
            this.lista_senhas.Location = new System.Drawing.Point(12, 12);
            this.lista_senhas.Name = "lista_senhas";
            this.lista_senhas.Size = new System.Drawing.Size(218, 264);
            this.lista_senhas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 288);
            this.Controls.Add(this.lista_senhas);
            this.Controls.Add(this.btn_gerar);
            this.Controls.Add(this.numero_char);
            this.Controls.Add(this.checkBox_simbolos);
            this.Controls.Add(this.checkBox_algarismos);
            this.Controls.Add(this.checkBox_maiusculas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de senhas";
            ((System.ComponentModel.ISupportInitialize)(this.numero_char)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_maiusculas;
        private System.Windows.Forms.CheckBox checkBox_algarismos;
        private System.Windows.Forms.CheckBox checkBox_simbolos;
        private System.Windows.Forms.NumericUpDown numero_char;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.ListBox lista_senhas;
    }
}

