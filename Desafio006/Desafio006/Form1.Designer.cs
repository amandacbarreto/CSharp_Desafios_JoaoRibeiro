
namespace Desafio006
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_clear = new System.Windows.Forms.Button();
            this.list_products = new System.Windows.Forms.ListBox();
            this.list_cart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor_total = new System.Windows.Forms.TextBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(20, 380);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(268, 23);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "NOVA COMPRA";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // list_products
            // 
            this.list_products.FormattingEnabled = true;
            this.list_products.ItemHeight = 15;
            this.list_products.Location = new System.Drawing.Point(20, 40);
            this.list_products.Name = "list_products";
            this.list_products.Size = new System.Drawing.Size(268, 334);
            this.list_products.TabIndex = 1;
            // 
            // list_cart
            // 
            this.list_cart.FormattingEnabled = true;
            this.list_cart.ItemHeight = 15;
            this.list_cart.Location = new System.Drawing.Point(305, 40);
            this.list_cart.Name = "list_cart";
            this.list_cart.Size = new System.Drawing.Size(268, 304);
            this.list_cart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "LISTA DE COMPRAS";
            // 
            // valor_total
            // 
            this.valor_total.Location = new System.Drawing.Point(305, 350);
            this.valor_total.Name = "valor_total";
            this.valor_total.Size = new System.Drawing.Size(268, 23);
            this.valor_total.TabIndex = 5;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(305, 380);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(268, 23);
            this.btn_buy.TabIndex = 6;
            this.btn_buy.Text = "FINALIZAR COMPRA";
            this.btn_buy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 423);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.valor_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_cart);
            this.Controls.Add(this.list_products);
            this.Controls.Add(this.btn_clear);
            this.Name = "Form1";
            this.Text = "Supermercado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox list_products;
        private System.Windows.Forms.ListBox list_cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor_total;
        private System.Windows.Forms.Button btn_buy;
    }
}

