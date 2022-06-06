using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio003
{
    public partial class Form1 : Form
    {
        int num_senhas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";

            if (checkBox_maiusculas.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (checkBox_algarismos.Checked)
                chars += "0123456789";
            if (checkBox_simbolos.Checked)
                chars += "#/$!?=-";

            lista_senhas.Items.Clear();
            Random rnd = new Random();

            for (int n = 1; n <= num_senhas; n++)
            {
                StringBuilder str = new StringBuilder();

                for (int m = 1; m<=numero_char.Value; m++)
                {
                    int posicao = rnd.Next(0, (chars.Length));
                    str.Append(chars[posicao].ToString());
                }

                lista_senhas.Items.Add(str.ToString());
            }
        }
    }
}
