using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio006
{
    public partial class Form1 : Form
    {
        private SortedList Products = new SortedList();

        private void RegisterProducts()
        {
            Products.Add("Cerveja importada(330 ml)", 12.20);
            Products.Add("Cerveja nacional(0,5 litros)", 6.1);
            Products.Add("Garrafa de vinho(qualidade média)", 40.0);
            Products.Add("Água(garrafa de 1,5 litros)", 3.2);
            Products.Add("Alface(1 unidade)", 3.4);
            Products.Add("Cebolas(1kg)", 4.7);
            Products.Add("Batatas(1 kg)", 5.1);
            Products.Add("Tomates(1 kg)", 8.50);
            Products.Add("Laranjas(1 kg)", 4.6);
            Products.Add("Bananas(1kg)", 5.30);
            Products.Add("Maçãs(1 kg)", 7.6);
            Products.Add("Queijo fresco(1 kg)", 40.9);
            Products.Add("Uma dúzia de ovos", 9.5);
            Products.Add("Arroz(1 kg)", 5.8);
            Products.Add("Pão massa grossa(1 kg)", 7.0);
            Products.Add("Leite(1 litro)", 4.6);
        }

        private void ListProducts()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                //list_products.Text = ($"{Products.GetKey(i)} - {Products.GetByIndex(i)}");
            }
        }

        public Form1()
        {
            InitializeComponent();
            RegisterProducts();
            
            //ListProducts();
        }


    }
}
