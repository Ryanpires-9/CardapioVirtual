using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardapioVirtual
{
    public partial class cardapio : Form
    {
        public cardapio()
        {
            InitializeComponent();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            tabControl_Detalhes.Enabled = true;

            if (lblNumeroPedido.Text == "?")
            {
                lblNumeroPedido.Text = "1";
            }
            else
            {
                lblNumeroPedido.Text = (int.Parse(lblNumeroPedido.Text)+ 1).ToString();
            }
            lblNumeroPedido/*Itens*/.Text = lblNumeroPedido.Text;
            dtpData.Value = DateTime.Now;
            btnCancelar.Enabled = true;

        }

        private void btnGravaXML_Click(object sender, EventArgs e)
        {

        }

        private void btnGravaTXT_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnResumo_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMandaItens_Click(object sender, EventArgs e)
        {

        }

    }
}
