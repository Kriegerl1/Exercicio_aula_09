using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        ControladorContato ControladorContato;
        RepositorioContato repositorioContato;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;
            toolLabelPrincipal.Text = string.Empty;
            repositorioContato = new RepositorioContato();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);
            lblTipoCadastro.Text = "Cadastro de " + controlador.tipoCadastro;

            toolLabelPrincipal.Text = $"Visualizando {Convert.ToString(repositorioContato.SelecionarTodos().Count)} registro(s)";

            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagemContato);

        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
            toolLabelPrincipal.Text = $"Visualizando {Convert.ToString(repositorioContato.SelecionarTodos().Count)} registro(s)";

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();

        }
        private void compromissosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
