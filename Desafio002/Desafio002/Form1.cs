using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operacao (double num1, double num2, string operador)
        {
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "x":
                    resultado = num1 * num2;
                    break;
                case ":":
                    resultado = num1 / num2;
                    break;
            }
            
            lbl_resultado.Text = $"{num1}{operador}{num2}={resultado}";
        }

        private void operacao(object sender, EventArgs e)
        {
            if (numero1.Text != "" && numero2.Text != "")
            {
                operacao(Double.Parse(numero1.Text), Double.Parse(numero2.Text), ((sender as Button).Text) );
            }
        }
    }
}
