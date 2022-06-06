
namespace Desafio001
{
    partial class tela_login
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
            this.cmd_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_entrar
            // 
            this.cmd_entrar.Location = new System.Drawing.Point(73, 153);
            this.cmd_entrar.Name = "cmd_entrar";
            this.cmd_entrar.Size = new System.Drawing.Size(75, 23);
            this.cmd_entrar.TabIndex = 2;
            this.cmd_entrar.Text = "Entrar";
            this.cmd_entrar.UseVisualStyleBackColor = true;
            this.cmd_entrar.Click += new System.EventHandler(this.cmd_entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(18, 47);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(182, 20);
            this.text_usuario.TabIndex = 0;
            this.text_usuario.TextChanged += new System.EventHandler(this.text_textChanged);
            this.text_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_usuario_KeyDown);
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(18, 105);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(182, 20);
            this.text_senha.TabIndex = 1;
            this.text_senha.TextChanged += new System.EventHandler(this.text_textChanged);
            this.text_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_senha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 194);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_entrar);
            this.Name = "tela_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.Label label2;
    }
}

