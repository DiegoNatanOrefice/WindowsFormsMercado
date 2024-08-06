using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtProdutos.Text += Environment.NewLine + txtProduto.Text + " | " + txtQtde.Text + " | " + txtValor.Text;
            double total = double.Parse(lblTotal.Text);
            double qtde = double.Parse(txtQtde.Text);
            double valor = double.Parse(txtValor.Text);
            total += qtde * valor;
            lblTotal.Text = total.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            txtProdutos.Clear();
            lblTotal.Text = "0";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
