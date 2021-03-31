using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaRAD01
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void radPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            trocarTipoPessoa("CNPJ:", "00.000.000/0000-00");
        }

        private void radPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            trocarTipoPessoa("CPF:", "000.000.000-00");
        }

        private void trocarTipoPessoa(string texto, string mask)
        {
            lblCPFCNPJ.Text = texto;
            txtCPFCNPJ.Mask = mask;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtCPFCNPJ.Text + " " + txtNome.Text);
        }
    }
}
