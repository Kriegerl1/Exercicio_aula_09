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
    public partial class ListagemContatoControl : UserControl
    {
        public ListagemContatoControl()
        {
            InitializeComponent();

            //listContatos.Items.Add(new Contato("Leo", "4998076236", "Lthkrieger@gmail.com", "Gocil", "Controlador de acesso"));
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            foreach (Contato contato in contatos)
            {
                listContatos.Items.Add(contato);
            }
        }

    }
}
