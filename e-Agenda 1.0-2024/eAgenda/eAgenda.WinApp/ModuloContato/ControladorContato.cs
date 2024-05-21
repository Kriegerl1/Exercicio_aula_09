using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemContatoControl listagemContato;


        public ControladorContato(RepositorioContato repositorio)
        {
            repositorioContato = repositorio;
        }

        public override string tipoCadastro { get { return "Contatos"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar um novo Contato"; } }
        public override string ToolTipEditar { get { return "Editar um Contato existente"; } }
        public override string ToolTipExcluir { get { return "Deletar um Contato"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Contato novoContato = telaContato.Contato;

                repositorioContato.Cadastrar(novoContato);

                MessageBox.Show("Novo Contato Registrado!");
                CarregarContatos();
            }
        }

        public override void Editar()
        {

         
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemContato == null)
                listagemContato = new ListagemContatoControl();

            CarregarContatos();

            return listagemContato;
        }
    }
}
