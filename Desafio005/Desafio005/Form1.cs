using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio005
{
    public partial class Form1 : Form
    {
        int numero, tentativas = 0, minimo = 0, maximo = 1000;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_numero.Enabled = false;
        }

        private void txt_numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txt_numero.Text!="")
            {
                tentativas++;
                if (Int32.Parse(txt_numero.Text) != numero)
                {
                    if (Int32.Parse(txt_numero.Text) > numero)
                    {
                        lbl_informacao.Text = "O numero é mais baixo";
                    }
                    else
                    {
                        lbl_informacao.Text = "O numero é mais alto";
                    }
                }
                else
                {
                    lbl_informacao.Text = $"Acertou! Você precisou de {tentativas} tentativas.";
                    txt_numero.Enabled = false;
                    btn_adivinhar.Enabled = true;
                    btn_adivinhar.Focus();
                }
            }
        }

        private void btn_adivinhar_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            numero = rdn.Next(minimo,maximo);
            tentativas = 0;
            lbl_informacao.Text = $"Jogo iniciado! Adivinhe o número entre {minimo} e {maximo}.";
            txt_numero.Enabled = true;
            txt_numero.Text = "";
            txt_numero.Focus();
            btn_adivinhar.Enabled = false;
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

    }
}
