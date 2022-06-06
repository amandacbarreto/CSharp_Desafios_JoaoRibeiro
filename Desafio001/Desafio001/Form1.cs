using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio001
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_entrar.Enabled = false;
        }

        private void text_textChanged(object sender, EventArgs e)
        {
            cmd_entrar.Enabled = (text_usuario.Text != "") && (text_senha.Text != "");
        }

        private void text_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                text_senha.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd_entrar_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmd_entrar_Click(object sender, EventArgs e)
        {
            if (!(cmd_entrar.Enabled)) return;
            MessageBox.Show("Entrou!");
        }
    }
}
