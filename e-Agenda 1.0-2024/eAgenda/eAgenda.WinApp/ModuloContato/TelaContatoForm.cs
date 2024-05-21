using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public Contato Contato { get { return contato; } }
        public TelaContatoForm()
        {
            InitializeComponent();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtCargo.Text;
            string email = txtEmpresa.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtNomee.Text;
            string empresa = txtEmail.Text;

            contato = new Contato(nome, telefone, email, empresa, cargo);
        }


    }
}
