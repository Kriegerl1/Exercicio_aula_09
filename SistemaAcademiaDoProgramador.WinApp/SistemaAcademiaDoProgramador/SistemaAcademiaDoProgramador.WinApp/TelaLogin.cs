using SistemaAcademiaDoProgramador.WinApp.ModuloUsuario;

namespace SistemaAcademiaDoProgramador.WinApp
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            lblMessage.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string LoginEsperado = "Krieger";
            string SenhaEsperado = "123456";
            string Login = txtNome.Text;
            string Senha = txtSenha.Text;

            Usuario UsuarioTentativaLogin = new(Login, Senha);

            List<string> erros = UsuarioTentativaLogin.Validar();

            if (erros.Count > 0)
            {
                MessageBox.Show(
                    string.Join('\n', erros),
                          "Tela de Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (Login != LoginEsperado || Senha != SenhaEsperado)
            {
                MessageBox.Show(
                    "Seu Login ou senha estão incorretos!",
                    "Tela de Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
                MessageBox.Show(
                    "Olá Mundo!",
                    $"Seja Bem-vindo, {txtNome}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

            lblMessage.Text = $"Seja bem-vindo(a), {Login}!";
        }
    }
}
